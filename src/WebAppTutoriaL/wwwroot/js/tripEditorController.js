(function () {
"use strict";

    angular.module("app-trips")
    .controller("tripEditorController", tripEditorController);

    function tripEditorController($routeParams, $http) {
        var vm = this;
        vm.tripName = $routeParams.tripName;
        vm.newStop = {};

        vm.stops = [];
        vm.errorMessage = "";
        vm.isBusy = true;

        var url = "/api/trips/" + vm.tripName + "/stops";
        $http.get(url)
        .then(function (response) {
            //Success
            angular.copy(response.data, vm.stops);
            _showMap(vm.stops);
        }, function (err) {
            //Failure
            vm.errorMessage = "Failed to load stops. " + err;
        }).finally(function () {
            vm.isBusy = false;
        });

        vm.addStop = function () {
            vm.isBusy = true;

            $http.post(url, vm.newStop)
                .then(function (responce) {
                    //Success
                    vm.stops.push(responce.data);
                    _showMap(vm.stops);
                    vm.newStop = {};
                }, function (err) {
                    //Failure
                    vm.errprMessage = "Failed to add new stop. " + err;
                })
                .finally(function () {
                    vm.isBusy = false;
                });
        };
    }

    function _showMap(stops) {
        if (stops && stops.length > 0) {

            var mapStops = _.map(stops, function (item) {
                return {
                    lat: item.latitude,
                    long: item.longitude,
                    info: item.name + " - " + item.arrival
                };
            });
            //Show map
            travelMap.createMap({
                stops: mapStops,
                selector: "#map",
                currentStop: 0,
                initialZoom:3
            });
        }
    }

})();
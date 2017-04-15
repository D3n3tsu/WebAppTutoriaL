(function () {

    "use strict";
    angular.module("app-trips")
    .controller("tripsController", tripsController);

    function tripsController() {
        var vm = this;

        vm.trips = [{
            name: "one trip",
            created: new Date
        },
        {
            name: "second trip",
            created: new Date
        }];
    }
})();
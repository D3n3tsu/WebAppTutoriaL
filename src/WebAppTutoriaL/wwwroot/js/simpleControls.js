
(function () {
"use strict";

angular.module("simpleControls", [])
    .directive("waitCursor", waitCursor);

function waitCursor() {
    return {
        restrict: "E",
        scope: {
            show: "=displayWhen"
        },
        templateUrl: "/views/waitCursor.html"
    };
}
})();
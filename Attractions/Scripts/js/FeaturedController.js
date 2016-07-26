//FeaturedController.js

(function () {

    "use strict";

    angular.module("app").controller("FeaturedController", featuredController);

    function featuredController($scope, dataService, $timeout) {

        $scope.slickReady = false;

        $scope.Featured = [];

        $scope.Featured = dataService.getFeaturedAttractions();

        $timeout(function () {
            $scope.slickReady = true;
        }, 500);
    }

})();
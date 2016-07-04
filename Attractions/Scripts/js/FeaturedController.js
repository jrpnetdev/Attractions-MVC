//FeaturedController.js

(function () {

    "use strict";

    angular.module("app").controller("FeaturedController", featuredController);

    function featuredController($scope, dataService) {

        $scope.Featured = [];

        $scope.Featured = dataService.getFeaturedAttractions();

    }

})();
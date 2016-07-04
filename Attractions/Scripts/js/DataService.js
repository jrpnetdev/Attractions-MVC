//DataService.js

(function() {

    "use strict";

    angular.module("app").factory("dataService", dataService);

    function dataService($http) {
        
        return {
            getAllAttractions: getAllAttractions,
            getFeaturedAttractions: getFeaturedAttractions,
            findAttractions: findAttractions
        }

        function getAllAttractions() {
            var attractions = [];

            $http.get("/api/v1/attractions")
            .then(function (response) {
                // Success
                angular.copy(response.data, attractions);
            }, function () {
                // Failure
            });
            return attractions;
        }

        function getFeaturedAttractions() {
            var featured = [];

            $http.get("/api/v1/featured")
            .then(function (response) {
                // Success
                angular.copy(response.data, featured);
            }, function () {
                // Failure
            });

            return featured;
        }

        function findAttractions(searchText) {
            var attractions = [];

            $http.get("/api/v1/attractions?searchText=" + searchText)
                .then(function (response) {
                    // Success
                    angular.copy(response.data, attractions);
                }, function () {
                    // Failure
                });

            return attractions;
        }
    }

})();
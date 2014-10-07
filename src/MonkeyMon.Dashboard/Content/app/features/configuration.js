(function() {

    var monkeymon = angular.module('monkeymon');

    monkeymon.controller('configuration', function($scope, $http) {

        $scope.name = "";

        $http.get('/api/configuration/name').then(function (result) {
            $scope.name = result.data.Name;
        });

    });

})();
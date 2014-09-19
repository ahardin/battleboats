angular.module('BattleBoatsApp.controllers', []).
controller('joinGameController', function ($scope) {
    $scope.joinGame = function() {
        console.log($scope.username);
    };

    $scope.username = '';
});
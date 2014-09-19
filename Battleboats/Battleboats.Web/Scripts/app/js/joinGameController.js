angular.module('BattleBoatsApp.controllers', []).
controller('joinGameController', ['$scope', '$rootScope', 'gameService', function ($scope, $rootScope, gameService) {
    $scope.joinGame = function () {
        gameService.joinGame($scope.username);
        console.log('joinGame: ' + $scope.username);
    };

    $rootScope.$on('userJoined', function (e, data) {
        console.log('userJoined response: ' + data);
    });

    $scope.username = '';
}]);
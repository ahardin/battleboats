angular.module('BattleBoatsApp.services', []).
  factory('gameservice', function ($http) {

      var dataAPI = {};

      dataAPI.joinGame = function (userName) {
          return $http({
              method: '',
              url: ''
          });
      };

      return dataAPI;
  });
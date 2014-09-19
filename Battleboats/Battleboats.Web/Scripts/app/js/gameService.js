angular.module('BattleBoatsApp.services', ['SignalR']).
  factory('gameService', ['$rootScope', 'Hub', function ($rootScope, Hub) {

      //declaring the hub connection (from the server)
      var hub = new Hub('BattleBoatsHub', {

          //client side methods
          listeners: {
              'JoinResponse': function (userId) {
                  $rootScope.$broadcast('userJoined', userId);
              }
          },

          //server side methods
          methods: ['Join'],

          //query params sent on initial connection
          queryParams: {
          },

          //handle connection error
          errorHandler: function (error) {
              console.error(error);
          }

      });

      // methods to the server
      var join = function (username) {
          hub.Join(username);
      }

      return {
          joinGame: join
      };

  }]);
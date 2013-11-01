﻿
'use strict';

flockApp.controller('userInfoController', function ($scope, userService, quackService) {

    $scope.$on('userInfoController.showUserInformation', function () {
        $scope.userPreferences = angular.copy($scope.user);
        $scope.userPreferences.Project = $scope.userProject;
        $scope.userPreferences.Interests = $scope.userInterest;
    });

    $scope.userPreferences = {};
    $scope.savePreferences = function () {
        userService.updateUserPreferences($scope.userPreferences).then(function () {
            $scope.userPreferences.Project = $scope.userProject;
            $scope.userPreferences.Interests = $scope.userInterest;
        });
    };

});
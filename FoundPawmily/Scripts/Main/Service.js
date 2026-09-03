app.service("FoundPawmilyService", function ($http) {
    this.pettoadopt = '';

    //1
    //this.getUserInfo = function () {
    //    return $http.get("/Main/GetUserInformation");
    //}

    //2 - for passing parameters from the main controller selected
    //this.concatenateInfo = function (fname, tphone) {
    //    var response = $http({
    //        method: "post",
    //        url: "/Main/ConcatenateInformation",
    //        params: {
    //            firstname: fname, should be same with the parameters in the controller
    //            telephone: tphone should be same with the parameters in the controller
    //        }
    //    });

    //    return response;
    //}
    //
    //3 - for passing parameters from the main controller collectively
    //this.jsonInfo = function (userInfo) {
    //    var response = $http({
    //        method: "post",
    //        url: "/Main/JSONInformation",
    //        data: userInfo,
    //    });

    //    return response;
    //}




    //CHARTS
    this.chartPetsService = function () {
        return $http.get("/Main/ChartPetsDataFunc");
    }

    this.chartVolunteersService = function () {
        return $http.get("/Main/ChartVolunteersDataFunc");
    }

    this.chartAdoptionsService = function () {
        return $http.get("/Main/ChartAdoptionsDataFunc");
    }

    this.getDashboardCounts = function () {
        return $http.get("/Main/DashboardCounts");
    };









    //PDFMAKE
    this.getAdoptionReportData = function () {
        return $http.get("/Main/GetAdoptionReportData");
    };

    this.getVolunteerReportData = function () {
        return $http.get("/Main/GetVolunteerReportData");
    };

    this.getPetReportData = function () {
        return $http.get("/Main/GetPetReportData");
    };













    //LOGIN SERVICE
    this.toLoginSession = function (loginData) {
        var response = $http({
            method: "post",
            url: "/Main/LoginSession",
            data: loginData,
        });

        return response;
    }


    //TABLE PETS
    //hindi pa pero ayaw nairename
    this.archivedServicePets = function () {
        return $http.get("/Main/GetNotArchivedDataPets");
    }

    //talagang hindi nakaarchive na
    this.reeallyArchivedServicePets = function () {
        return $http.get("/Main/GetNotReallyArchivedDataPets");
    }

    this.toArchiveServicePets = function (petID) {
        var response = $http({
            method: "post",
            url: "/Main/ToArchivedFuncPets",
            params: {
                PetID: petID
            }
        });

        return response;
    }




    //TABLE LOGS

    this.serviceLogs = function () {
        return $http.get("/Main/GetLogs");
    }


    //TABLE ADOPTIONS

    this.archivedServiceAdoptions = function () {
        return $http.get("/Main/GetNotArchivedDataAdoptions");
    }

    this.toArchiveServiceAdoptions = function (adoptID) {
        var response = $http({
            method: "post",
            url: "/Main/ToArchivedFuncAdoptions",
            params: {
                AdoptID: adoptID
            }
        });

        return response;
    }



    //TABLE VOLUNTEERS

    this.archivedServiceVolunteers = function () {
        return $http.get("/Main/GetNotArchivedDataVolunteers");
    }

    this.toArchiveServiceVolunteers = function (volunteerID) {
        var response = $http({
            method: "post",
            url: "/Main/ToArchivedFuncVolunteers",
            params: {
                VolunteerID: volunteerID
            }
        });

        return response;
    }

    //TABLE USERS
    this.archivedServiceUsers = function () {
        return $http.get("/Main/GetNotArchivedDataUsers");
    }

    this.toArchiveServiceUsers = function (userID) {
        var response = $http({
            method: "post",
            url: "/Main/ToArchivedFuncUsers",
            params: {
                UserID: userID
            }
        });

        return response;
    }








    this.getPetProfileService = function (petID) {
        var response = $http({
            method: "post",
            url: "/Main/GetPetProfile",
            params: {
                id: petID
            }
        });

        return response;
    }

    this.getAdoptionService = function (adoptionID) {
        var response = $http({
            method: "post",
            url: "/Main/GetAdoption",
            params: {
                id: adoptionID
            }
        });

        return response;
    }

    this.getVolunteerService = function (volunteerID) {
        var response = $http({
            method: "post",
            url: "/Main/GetVolunteer",
            params: {
                id: volunteerID
            }
        });

        return response;
    }

    this.getUserService = function (userID) {
        var response = $http({
            method: "post",
            url: "/Main/GetUser",
            params: {
                id: userID
            }
        });

        return response;
    }

    this.getProfileService = function () {
        return $http.get("/Main/GetProfile");
    }


    this.getPetsService = function (petType) {
        var response = $http({
            method: "post",
            url: "/Main/GetPets",
            params: {
                type: petType
            }
        });

        return response;
    }

    //UPDATE PET IMAGE
    this.updatePetImageService = function (file) {
        var formData = new formData();
        formData.append('file', file);

        var response = $http({
            method: "post",
            url: "/Main/UpdatePetImage",
            data: formData,
            headers: {
                'Content-Type': undefined
            },
            transformRequest: angular.identity
        });
        return response;
    }

    //UPDATE PET data (finished)
    this.updatePetData = function (petData) {
        var response = $http({
            method: "post",
            url: "/Main/UpdatePetData",
            data: petData
        });

        return response;
    }

    //UPDATE ADOPT data (finished)
    this.updateAdoptData = function (adoptData) {
        var response = $http({
            method: "post",
            url: "/Main/UpdateAdoptData",
            data: adoptData
        });

        return response;
    }

    //UPDATE VOLUNTEER data (finished)
    this.updateVolunteerData = function (volunteerData) {
        var response = $http({
            method: "post",
            url: "/Main/UpdateVolunteerData",
            data: volunteerData
        });

        return response;
    }

    //UPDATE USER data (finished)
    this.updateUserData = function (userData) {
        var response = $http({
            method: "post",
            url: "/Main/UpdateUserData",
            data: userData
        });

        return response;
    }

    //UPDATE PROFILE data (finished)
    this.updateProfile = function (userData) {
        var response = $http({
            method: "post",
            url: "/Main/UpdateProfile",
            data: userData
        });

        return response;
    }






    

    this.toPassAdoptData = function (adoptData) {
        var response = $http({
            method: "post",
            url: "/Main/PassAdoptData",
            data: adoptData,
        });

        return response;
    }


    this.toPassVolunteerData = function (volunteerData) {
        var response = $http({
            method: "post",
            url: "/Main/PassVolunteerData",
            data: volunteerData,
        });

        return response;
    }

    //PASS PET DATA
    this.toInsertPetData = function (petData) {
        var response = $http({
            method: "post",
            url: "/Main/InsertPetData",
            data: petData,
        });

        return response;
    }

    this.insertAdoptData = function (adoptData) {
        var response = $http({
            method: "post",
            url: "/Main/InsertAdoptData",
            data: adoptData,
        });

        return response;
    }

    this.insertVolunteerData = function (volunteerData) {
        var response = $http({
            method: "post",
            url: "/Main/InsertVolunteerData",
            data: volunteerData,
        });

        return response;
    }

    this.insertUserData = function (signUpData) {
        var response = $http({
            method: "post",
            url: "/Main/InsertUserData",
            data: signUpData,
        });
        return response;
    }

});
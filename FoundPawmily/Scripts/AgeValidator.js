    app.directive("validateAge", function () {
        return {
            require: "ngModel",
            link: function (scope, element, attrs, ngModel) {
                ngModel.$validators.age = function (inputDate) {
                    if (!inputDate) return false;

                    const today = new Date();
                    const birthDate = new Date(inputDate);

                    let age = today.getFullYear() - birthDate.getFullYear();
                    if (
                        today.getMonth() < birthDate.getMonth() ||
                        (today.getMonth() === birthDate.getMonth() &&
                            today.getDate() < birthDate.getDate())
                    ) {
                        age--;
                    }

                    return age >= 18;
                };
            }
        };
    });
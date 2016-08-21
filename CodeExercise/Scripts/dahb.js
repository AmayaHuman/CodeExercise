
// Setup an event listener to make an API call once auth is complete
function onLinkedInLoad() {
    IN.Event.on(IN, "auth", getProfileData);
}

// Handle the successful return from the API call
function onSuccess(data) {

    $.ajax({
        type: "POST",
        url: "/Home/SuccessfulAuthorization",
        data: {
            LinkedinId: data.Id,
            FirstName: data.firstName,
            LastName: data.lastName,
            Headline: data.headline,
            ProfileUrl: data.publicProfileUrl,
            PictureUrl: data.pictureUrl,
            EmailAddress: data.emailAddress
        },
        //contentType: "application/json",
        dataType: "html",
        success: function (result) {
            $(".request-signin").hide();
            $(".CTA-content")[0].innerHTML = result;
        },
        error: function (jqXHR, textStatus, errorThrown) {
            onError(errorThrown);
        }

    });
    console.log(data);
}

// Handle an error response from the API call
function onError(error) {
    console.log(error);
}

// Use the API call wrapper to request the member's basic profile data
function getProfileData() {
    IN.API.Raw("/people/~:(id,first-name,last-name,headline,public-profile-url,picture-url,email-address)").result(onSuccess).error(onError);
    //IN.API.Raw("/people/~").result(onSuccess).error(onError);
}

$(".CTA-content").on("click", "#request-consultation.button", function (e) {
    var userCard = $(e.target).parents(".user-card");

    var firstName = userCard.find("#FirstName").val();
    var lastName = userCard.find("#LastName").val();
    var emailAddress = userCard.find("#EmailAddress").val();

    //Really should validate values.

    //submitting values
    $.ajax({
        type: "POST",
        url: "Home/RequestConsultation",
        data: {
            firstName: firstName,
            lastName: lastName,
            emailAddress: emailAddress
        },
        success: function (result) {
            $(".CTA-content")[0].innerHTML = result;
        },
        error: function (jqXHR, textStatus, errorThrown) {
            onError(errorThrown);
        }
    });
});
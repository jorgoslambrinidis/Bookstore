$(document).ready(function () {
    console.log("Document Ready from included JS Script!!!");
});

$("#AuthorID").change(function () {
    var optionSelected = $("option:selected", this);
    //console.log(optionSelected);

    // *** 1st case for getting the name
    var optionName1 = optionSelected[0].innerHTML;
    //console.log("OptionName 1: " + optionName1);

    // *** 2nd case for getting the name
    var optionName2 = optionSelected.text();
    //console.log("OptionName 2: " + optionName2);

    $("#AuthorName").val(optionName2);
    //console.log("AuthorName: " + $("#AuthorName").val());
});

$("#PublisherID").change(function () {
    var optionSelected = $("option:selected", this);
    var optionName = optionSelected.text();
    $("#PublisherName").val(optionName);
});

$("#CategoryID").change(function () {
    var optionSelected = $("option:selected", this);
    var optionName = optionSelected.text();
    $("#CategoryName").val(optionName);
});

$("#addNewAuthor").click(function () {

    var data = {
        Name: $("#AuthorNameDTO").val(),
        Country: $("#AuthorCountryDTO").val(),
        DateBirth: $("#AuthorDateBirthDTO").val(),
        ShortDescription: $("#AuthorShortDescriptionDTO").val(),
        Language: $("#AuthorLanguageDTO").val(),
        Gender: $("#AuthorGenderDTO").val()
    };

    $.ajax({
        type: "POST",
        url: "/Author/CreateAuthorAJAX",
        data: data,
        dataType: "json",
        success: function (data) {
            //console.log(data);
            $("#AuthorID").append("<option value=" + data.id + ">" + data.name + "</option>"); 
        },
        error: function () {
            alert("Error Adding New Author!");
        }
    });
});

$("#addNewPublisher").click(function () {
   
});

$("#addNewCategory").click(function () {
   
});
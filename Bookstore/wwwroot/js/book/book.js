$(document).ready(function () {
    console.log("Document Ready from included JS Script!!!");
});

$("#AuthorID").change(function () {
    var optionSelected = $("option:selected", this);
    //console.log(optionSelected);
    // javascript -> var getVal = document.getElementById("AuthorName").value;
    // jquery -> $("#AuthorName").val();
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
            console.log(data.data);
            if (data.data == '') {
                $('#authorModal').modal('toggle');
                setTimeout(() => {
                    alert("Error: Author has NOT been added! Please enter data in all the fields!");
                }, 500); 
            } else {
                $("#AuthorID").append("<option value=" + data.data.id + ">" + data.data.name + "</option>");
                $("#AuthorID").val(data.data.id);
                $('#authorModal').modal('toggle');
            }
        },
        error: function () {
            alert("Error Adding New Author!");
        }
    });
});

$("#addNewPublisher").click(function () {

    var data = {
        Name: $("#PublisherNameDTO").val(),
        Country: $("#PublisherCountryDTO").val(),
        Year: $("#PublisherYearDTO").val()
    };

    $.ajax({
        type: "POST",
        url: "/Publisher/CreatePublisherAJAX",
        data: data,
        dataType: "json",
        success: function (data) {
            console.log(data);
            $("#PublisherID").append("<option value=" + data.id + ">" + data.name + "</option>");
        },
        error: function () {
            alert("Error Adding New Publisher!");
        }
    });
});

$("#addNewCategory").click(function () {

    var data = {
        Name: $("#CategoryNameDTO").val()
    };

    $.ajax({
        type: "POST",
        url: "/Category/CreateCategoryAJAX",
        data: data,
        dataType: "json",
        success: function (data) {
            console.log(data);
            $("#CategoryID").append("<option value=" + data.id + ">" + data.name + "</option>");
        },
        error: function () {
            alert("Error Adding New Category!");
        }
    });
});
$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Book/GetAllBooksAJAX/",
        success: function (data) {
            console.log(data);
            /*console.log(data.booksData[4].title);*/
           /* $("#bookTitleFromJSON").val(data.booksData[4].title);*/
        },
        error: function () {
            alert("Error getting all books!");
        }
    })
});
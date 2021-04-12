$(document).ready(function () {
    //$.ajax({
    //    type: "GET",
    //    url: "/Book/GetAllBooksAJAX/",
    //    success: function (data) {
    //        console.log(data);
    //        /*console.log(data.booksData[4].title);*/
    //       /* $("#bookTitleFromJSON").val(data.booksData[4].title);*/
    //    },
    //    error: function () {
    //        alert("Error getting all books!");
    //    }
    //})
    GetQuotes();

    setInterval(() => {
        GetQuotes();
    }, 5000);

});

function GetQuotes() {
    $.ajax({
        type: "GET",
        url: "/Home/GetQuotes/",
         //url: "https://type.fit/api/quotes",
        success: function (data) {
            $("#quote").text("\" " + data.quotes[0].quote + "\"");
            $("#quote_author").text(data.quotes[0].author);

            var quoteTags = data.quotes[0].tags;
            var tagsString = "";

            quoteTags.forEach(item => {
                var lastItem = quoteTags[quoteTags.length - 1];
                tagsString += item == lastItem ? item + "" : item + ","
            });

            $("#quote_tags").text(tagsString);         
        },
        error: function () {
            alert("Error");
        }
    })
}
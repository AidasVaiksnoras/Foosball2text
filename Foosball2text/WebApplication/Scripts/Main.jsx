var result;
var obj;

$(function () {
    var storiesInterval = 10 * 1000;
    var fetchNews = function () {
        console.log('Sending AJAX request...');
        $.ajax({
            type: "GET",
            url: "api/CurrentGame",
            data: {
                user: 'success',
                some: ['other', 'data']
            }
        }).done(function (msg) {
            $(msg).appendTo("#edix");
            console.log('success');
            console.log(msg);
            obj = JSON.parse(msg);
            console.log(obj.LeftUserName);
        }).fail(function () {
            console.log('error');
        }).always(function () {
            // Schedule the next request after this one completes,
            // even after error
            console.log('Waiting ' + (storiesInterval / 1000) + ' seconds');
            setTimeout(fetchNews, storiesInterval);
        });
    }

    // Fetch news immediately, then every 10 seconds AFTER previous request finishes
    fetchNews();
});


var CommentBox = React.createClass({
    render: function () {
        return (
            <div className="commentBox">
                <h1>Comments</h1>
                <h2> See console </h2>
            </div>
        );
    }
});

ReactDOM.render(
    <CommentBox data={obj} />,
    document.getElementById('content')
);
//function getGameData() {
//    return fetch('http://localhost:63526/api/CurrentGame')
//        .then((response) =>
//            response.json())
//        .then((responseJson) => { return responseJson.movies; })
//        .catch((error) => { console.error(error); });
//};
//componentDidMount() {
//     fetch('http://localhost:63526/api/CurrentGame')
//        .then((response) =>
//            response.json())
//        .then((responseJson) => { return responseJson.movies; })
//        .catch((error) => { console.error(error); });
//}
var CommentBox = React.createClass({
    render: function () {
        return (
            <div className="commentBox">
                Hello, world! I am a CommentBox.
      </div>
        );
    }
});
ReactDOM.render(
    <CommentBox />,
    document.getElementById('content')
);

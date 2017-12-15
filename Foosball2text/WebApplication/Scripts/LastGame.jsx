var obj;
var usr;
var interval = 100;

var GamesList = React.createClass({


    getInitialState: function () {
        return {
            games: []
        }
    },

    componentDidMount: function () {
        this.timer = setInterval(() => {
            $.ajax({
                type: "GET",
                url: "api/Game/10",
                data: {
                    user: 'success',
                    some: ['other', 'data']
                }
            }).done(function (data) {
                this.setState({ games: data });
                interval = 1000;
            }.bind(this));


        }, interval);
    },

render: function () {
    return (
        <div className="container">
            
            <table className="table table-hover ">
            <tbody>
            {this.state.games.map(game => {
                const parentgame = (
                    <tr key={`game-${game.id}`}>
                        <td className='alnright'>
                            <div className="parent">{game.LeftUserName}</div>
                        </td>
                        <td className="score">
                            {game.LeftScore}
                        </td>
                        <td>
                           :
                        </td>
                        <td className="score">
                            {game.RightScore}
                        </td>
                        <td>
                            {game.RightUserName}
                        </td>

                    </tr>
                );


                return [parentgame];
            })}
</tbody>
</table>
        </div>
    );
}
});





ReactDOM.render(
    <div> <GamesList />
    </div>,
    document.getElementById('content')
);
var obj;
var usr;
var interval = 100;

var CurrentResult = React.createClass({


    getInitialState: function () {
        return {
            leftUser: 'Loading',
            rightUser: 'Loading',
            leftScore: '0',
            rightScore: '0',
            isLeftVisible: false,
            isRightVisisble: false,
            UserName: '',
            GamesPlayed: 'Loading',
            GamesWon: 'Loading',
            MaxSpeed: 'Loading',
            TotalGoals: 'Loading'
        }
    },


    componentDidMount: function () {
        this.timer = setInterval(() => {
            $.ajax({
                type: "GET",
                url: "api/Game",
                data: {
                    user: 'success',
                    some: ['other', 'data']
                }
            }).done(function (msg) {
                obj = JSON.parse(msg);
            });
            this.setState({
                leftUser: obj.LeftUserName,
                rightUser: obj.RightUserName,
                leftScore: obj.LeftScore,
                rightScore: obj.RightScore
            })

            $.ajax({
                type: "GET",
                url: "api/User?id=" + this.state.UserName,
                data: {
                    user: 'success',
                    some: ['other', 'data']
                }
            }).done(function (usr) {
                this.setState({
                    UserName: usr.Username,
                    GamesPlayed: usr.GamesPlayed,
                    GamesWon: usr.GamesWon,
                    MaxSpeed: usr.MaxSpeed,
                    TotalGoals: usr.TotalGoals,
                    RankPoints: usr.RankPoints
                });

            }.bind(this));


        }, interval);
    },

   
    handleClickLeft: function () {
        if (this.state.isLeftVisible) {
            this.setState({ isLeftVisible: false });
        }
        else {
            this.setState({ isLeftVisible: true, UserName: this.state.leftUser });
        }
    },
    handleClickRight: function () {

        if (this.state.isLeftVisible) {
            this.setState({ isLeftVisible: false });
        }
        else {
            this.setState({ isLeftVisible: true, UserName: this.state.rightUser });
        }
    },


    render: function () {
        return (
            <div>
                <div className="score" style={{ textAlign: "center" }}>
                    <h1>Rezultatas</h1>

                    <h1>{this.state.leftScore} : {this.state.rightScore} </h1>

                    <table>
                        <tbody>
                            <tr>

                                <td className='alnright' onClick={this.handleClickLeft}>{this.state.leftUser}</td>
                                <td>&ensp;vs</td>
                                <td onClick={this.handleClickRight}>&ensp;{this.state.rightUser}</td>
                            </tr>
                        </tbody>
                    </table>

                </div>
                <div style={{ textAlign: "left" }}>
                    {this.state.isLeftVisible ?
                        <div>
                            <h2>{this.state.UserName}</h2>
                            <h3>Sužaidęs {this.state.GamesPlayed} žaidimus</h3>
                            <h3> Laimėjo: {this.state.GamesWon}</h3>
                            <h3>Max greitis: {this.state.MaxSpeed}</h3>
                            <h3>Bendrai įmušta: {this.state.TotalGoals}</h3>
                        </div> : null}
                </div>
            </div>
        );
    }
});


ReactDOM.render(
    <div> <CurrentResult />
    </div>,
    document.getElementById('content')
);
var obj;
var usr;
var passedUserName = '';
var interval = 1000;

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
            TotalGoals: 'Loading',
            RankPoints: 'Loading'
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
                    UserName: usr.UserName,
                    GamesPlayed: usr.GamesPlayed,
                    GamesWon: usr.GamesWon,
                    MaxSpeed: usr.MaxSpeed,
                    TotalGoals: usr.TotalGoals,
                    RankPoints: usr.RankPoints
                });

            }.bind(this));


        }, interval);
    },

    getStats: function () {
        this.timer = setInterval(() => {
            $.ajax({
                type: "GET",
                url: "api/User?id=" + this.state.UserName,
                data: {
                    user: 'success',
                    some: ['other', 'data']
                }
            }).done(function (usr) {
                console.log(usr.UserName);
                console.log(usr.GamesPlayed);
                this.setState({
                    UserName: usr.UserName,
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

                                <th onClick={this.handleClickLeft}>{this.state.leftUser}</th>
                                <th>&ensp;vs</th>
                                <th onClick={this.handleClickRight}>&ensp;{this.state.rightUser}</th>
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
                            <h3>Surinkę taškų: {this.state.RankPoints}</h3>
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
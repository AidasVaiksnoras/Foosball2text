var obj;
var usr;
var interval = 1000;
console.log(Username);
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
                url: "api/User?id=" + Username,
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



    render: function () {
        return (
            <div>
                <div style={{ textAlign: "left" }}>
                   
                            <h2>{this.state.UserName}</h2>
                            <h3>Sužaidęs {this.state.GamesPlayed} žaidimus</h3>
                            <h3> Laimėjo: {this.state.GamesWon}</h3>
                            <h3>Max greitis: {this.state.MaxSpeed}</h3>
                            <h3>Bendrai įmušta: {this.state.TotalGoals}</h3>
                        
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
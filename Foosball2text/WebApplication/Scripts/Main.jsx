var obj;
var user;
var interval = 1000;

var CurrentResult = React.createClass({


    getInitialState: function () {
        return {
            leftUser: '',
            rightUser: '',
            leftScore: '0',
            rightScore: '0'
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
                url: "api/User?id=" + obj.LeftUserName,
                data: {
                    user: 'success',
                    some: ['other', 'data']
                }
            }).done(function (usr) {
                console.log(usr);
                
            });

        }, interval);
    },


    render: function () {

        return (
            <h1>Rezultatas   {this.state.leftUser} {this.state.leftScore} : {this.state.rightScore} {this.state.rightUser} </h1>
        );
    }
});



ReactDOM.render(
    <CurrentResult />,
    document.getElementById('content')
);
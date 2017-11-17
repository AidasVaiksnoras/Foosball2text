
//var React = require('react-native');

var obj;


var SampleApp = React.createClass({


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
            });
            this.setState({
                leftUser: obj.LeftUserName,
                rightUser: obj.RightUserName,
                leftScore: obj.LeftScore,
                rightScore: obj.RightScore
            })
        }, 1000);
    },


    render: function () {

        return (
            <h1>Rezultatas   {this.state.leftUser} {this.state.leftScore} : {this.state.rightScore} {this.state.rightUser} </h1>
        );
    }
});



ReactDOM.render(
    <SampleApp />,
    document.getElementById('content')
);
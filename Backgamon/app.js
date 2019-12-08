
function connect() {
    console.log('connect');

    var url = this.location + "/signalr";
    var proxy = $.connection.gameHub;

    $.connection.hub.start()
        .done(function() {
            console.log('Connected.');
            proxy.server.send('test test');
        })
        .fail(function(err) {
            console.log('Connection Failed -> ' + err);
        });
}

function send() {
    console.log('send');
    var proxy = $.connection.gameHub;

    proxy.server.send('test test 22');
}

function createUser(user, pwd) {
    var req = { User: user, Password: pwd };
    $.post("/api/Users/CreateUser", req)
        .done(function(res) {
            console.log("User Create -> " + res);
        })
        .fail(function() {
            console.log("User Create");
        })
        .always(function() {
            console.log("finished");
        });


}


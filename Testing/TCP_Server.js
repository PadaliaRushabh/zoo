var tcp = require('net');
//var stdin = process.openStdin(); 

var Server = tcp.createServer();
var stdin = process.openStdin();
var pwd=[];
var ip=[];
var Cpwd = "Rushabh";

  Server.on('connection'  ,function(conn){
    conn.setEncoding('utf-8');
    conn.write("Password:");
    console.log("[" + conn.remoteAddress + "] has joined the chat");
     
  conn.on('data' , function(data){
    if(pwd.indexOf(conn)>-1){
      console.log("[" + conn.remoteAddress + "]:"  + data); 
      if(checkCommand(data) === 2){
        console.log("It's a command");
      }
      else if(pwd.length > 0){
     
        sendMessage(conn , data);
        
      }
    }
    else{
      data= data.toString('utf-8').trim();
      var message = " has joined the chat";
      if(Cpwd == data){ 
        pwd.push(conn); 
        ip.push(conn.remoteAddress);
        sendMessage(conn , message);
      }
      
      else {conn.write("Password rejected:" + data);conn.end();}
    }
       
  }); 
   
  conn.on('end' , function() { 
  var i , client;
    for(i in pwd){
      client = pwd[i];
      if(!client.writable){
        pwd.splice(i,1);
        console.log(ip[i]+ " has left the chat");
        ip.splice(i,1);
      }
    }
    
  });  
}); 

function sendMessage(conn , message){
 
  var i , client;
  for(i in pwd){
    client = pwd[i];
    if(client.writable){
   
      if(conn === client){
     
        //message = "[me]:" + message; 
        client.write("[me]:" + message);
        
      }
    
      else
        client.write("[" + conn.remoteAddress +"]:" + message);
    }
    else{
      pwd.splice(i , 1);
      console.log(ip[i]+ " has left the chat");
      ip.splice(i,1);
    }   
  }
}

function checkCommand(message){
  
  var result = /[^//]+/.exec(message);
  return result.index;
  
}

Server.listen(8000);



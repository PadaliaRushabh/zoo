using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Threading;


public class clnt {

	public static System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
	public static NetworkStream serverStream = default(NetworkStream);
    public static void Main() {
        
        try {
        
        	
       		
        	
        	
        	//readData = "Conected...";
               // msg();
                clientSocket.Connect("127.0.0.1", 8000);
                //serverStream = clientSocket.GetStream();

                /*byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBox3.Text + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();*/

               Thread ctThread = new Thread(getMessage);
               ctThread.Start();
               

               
              
        }
        
        catch (Exception e) {
            Console.WriteLine("Error..... " + e.StackTrace);
        }
    }
    
      private static void getMessage(){
      string readData = null;
			while (true){
			
                		serverStream = clientSocket.GetStream();
                		int buffSize = 0;
                		byte[] inStream = new byte[100];
                		//buffSize = clientSocket.ReceiveBufferSize;
                		//buffSize = Math.Min(clientSocket.ReceiveBufferSize, buffer.Length);
                		serverStream.Read(inStream, 0, 100);
                		string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                		readData = "" + returndata;
                		Console.WriteLine(readData);
            		}
        	}

        	/*private  void msg(){
            
                		Console.WriteLine(readData);
        	}*/

  }


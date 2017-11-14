using UnityEngine;                        // These are the librarys being used
 using System.Collections;
 using System;
 using System.IO;
 using System.Net.Sockets; 
 
 public class ClientSocket : MonoBehaviour {
 
     bool socketReady = false;                // global variables are setup here
     TcpClient mySocket;
//	 Socket Client;
     public NetworkStream theStream;
//	//int life;
     StreamWriter theWriter;
     StreamReader theReader;
     public String Host = "INSERT the public IP of router or Local IP of Arduino";
     public Int32 Port = 80; 
     public bool lightStatus;
	 public bool listo = false;
	 public String mensaje = "nada";
	 bool configurado = false;
	 bool leer = false;
	 
     
 
     void Start() {
       //  setupSocket ();                        // setup the server connection when the program starts

	}
     
     // Update is called once per frame
     void Update() {

		if (listo) {
			setupSocket ();
			configurado = true;
			listo = false;
		}
			
		if(configurado)
//         while (theStream.DataAvailable) 
		if(leer)
			{                  // if new data is recieved from Arduino
			 //Debug.Log("recieve");
			
			 string recievedData = readSocket();            // write it to a string
			 
			 if (recievedData != "NoData")
			 Debug.Log(recievedData);

             if (recievedData == "hola") {            // compare that string and adjust the current light status accordingly
					Debug.Log("hola");
					//lightStatus = true;
             }
 
             if (recievedData == "Light off") {
                 lightStatus = false;
             }
			 
			 leer = false;
             }


     }
     
     public void setupSocket() {                            // Socket setup here
         try {                
            mySocket = new TcpClient(Host, Port);
            theStream = mySocket.GetStream();
			theStream.ReadTimeout = 10;

//			//Client.
			//mySocket.SendTimeout = 100000;
			//life = mySocket.SendTimeout;
			//life = theStream.WriteTimeout;
			//theStream.InitializeLifetimeService();
			//Debug.Log(life);

			 theWriter = new StreamWriter(theStream);
             theReader = new StreamReader(theStream);
             socketReady = true;
         }
         catch (Exception e) {
             Debug.Log("Socket error:" + e);                // catch any exceptions
         }
     }
     
     public void writeSocket(string theLine) {            // function to write data out
         if (!socketReady)
             return;
         String tmpString = theLine;
         theWriter.Write(tmpString);
         theWriter.Flush();
      }
     
	 public String readSocket() {                        // function to read data in
		if (!socketReady)
             return "nop";
		try {
			return theReader.ReadLine();
		} catch (Exception e) {
			Debug.Log("Socket error:" + e); 
			return "NoData";
		} 
	
	}

	public void writeMje() {            // function to write data out
		if (!socketReady)
			return;
		String tmpString = mensaje + "\n";
		theWriter.Write(tmpString);
		theWriter.Flush();
	}

     
     public void closeSocket() {                            // function to close the socket
         if (!socketReady)
             return;
         theWriter.Close();
         theReader.Close();
         mySocket.Close();
         socketReady = false;
     }
     
     public void maintainConnection(){                    // function to maintain the connection (not sure why! but Im sure it will become a solution to a problem at somestage)
//         if(!theStream.CanRead) {
             setupSocket();
         //}
     }
 
 
 } // end class ClientSocket
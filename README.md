#Node App Windows Launcher

Launch all your node apps (or anything I guess) easily with this windows service - simply add your application to application.json

##Get It Now
Just want to download and use it?
```http://j4m355.com/node-app-windows-launcher/```

##Installing
Run the windows installer at the above link. 

Edit the ```applications.json``` found in ```%AppData%\Node-App-Windows-Launcher\```.

Go to ```Services.msc``` and start ```node the ```Node-App-Windows-Launcher``` service. 

##Example Applications.json

```{
"Application":[{
				"Name" : "Top",
				"Path" : "C:\\code\\node-server-resource-monitor\\", 
				"Command" : "C:\\Program Files\\nodejs\\node.exe",
				"Parameters" : "index.js"
				},
				{
				"Name" : "whats-my-ip",
				"Path" : "C:\\code\\node-whats-my-ip\\", 
				"Command" : "C:\\Program Files\\nodejs\\node.exe",
				"Parameters" : "index.js"
				}]
}```



##What it does
Executes ```top``` or ```tasklist``` (if windows) on the server and returns the result to any client browser. Useful for keeping an eye on your servers. Looks pretty good on mobiles and tablets too.

![Alt text](/app/public/images/screenshot.png?raw=true "User Interface")




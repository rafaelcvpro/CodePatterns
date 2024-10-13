// See https://aka.ms/new-console-template for more information
using CodePatterns.Decorator_Pattern;
using CodePatterns.Factory_Method_Pattern;
using CodePatterns.Observer_Pattern;
using CodePatterns.Singleton_Pattern;
using CodePatterns.Prototype_Pattern; 
using System.Data.Common;

Console.WriteLine("Hello, World!");
// Run Singleton //

// Invoke Log Manager Write Method
LogManager.Instance.WriteLog("Test Log Manager");

// Factory Method Pattern //

// DbProviderFactory
// SQL Connection 
DatabaseFactory factory;
factory = new SqlServerFactory();
IDatabaseConnection sqlConneciton = factory.CreateConnection();
sqlConneciton.Connect();
 // switch to MySQL 
 factory = new MySqlFactory(); 
IDatabaseConnection mySqlConection = factory.CreateConnection();
mySqlConection.Connect();

// Observer Pattern //

//Creates the subject and observers, and changes the state of the subject to trigger notifications.
//In this example, when the State property of the Subject changes, it calls NotifyAllObservers, 
//which in turn calls the Update method on each observer, allowing them to react to the change. 
//This pattern ensures that all observers are kept in sync with the subject’s state.

Subject subject = new Subject();
new ConcreteObserver(subject); 
new ConcreteObserver(subject);
subject.State = 5; 
subject.State = 6;

// Decorator Pattern //
IMessage simpleMessage = new SimpleMessage("Hello, World");
Console.WriteLine(simpleMessage.GetMessage());

IMessage excitedMessage = new ExcitedMessageDecorator(simpleMessage);
Console.WriteLine(excitedMessage.GetMessage());

IMessage encryptedMessage = new EncryptedMessageDecorator(simpleMessage);
Console.WriteLine(encryptedMessage.GetMessage());

IMessage excitedEncryptedMessage = new EncryptedMessageDecorator(excitedMessage);
Console.WriteLine(excitedEncryptedMessage.GetMessage());

// Prototype Pattern
Settings settings = new Settings(); 
Settings settingsClone = (Settings)settings.Clone();

settingsClone.ApplicationSettings = "NewSettings"; 

Console.WriteLine("Instace 1:", settings.ToString());
Console.WriteLine("Instace 2:", settings.Clone().ToString());

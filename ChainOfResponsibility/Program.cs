using ChainOfResponsibility;

/*
 The Chain of Responsibility pattern is a behavioral design pattern that allows a request 
 to be passed along a chain of potential handlers until it finds the appropriate one to process it. 
 Each handler in the chain has the autonomy to handle the request or delegate it to the next handler. 
 This decoupled approach promotes flexibility, scalability, and maintainability in workflow management scenarios.
 */

Console.Title = "Chain of Responsibility Pattern";

// Create the support handlers
var level3SupportHandler = new Level3SupportHandler();
var level2SupportHandler = new Level2SupportHandler();
var level1SupportHandler = new Level1SupportHandler();

// Set the chain of responsibility
level1SupportHandler.SetNextHandler(level2SupportHandler);
level2SupportHandler.SetNextHandler(level3SupportHandler);

// Tickets
var ticket1 = new Ticket { Severity = Severity.Low };
var ticket2 = new Ticket { Severity = Severity.Medium };
var ticket3 = new Ticket { Severity = Severity.High };

// Process the tickets
level1SupportHandler.HandleTicket(ticket1);
level1SupportHandler.HandleTicket(ticket2);
level1SupportHandler.HandleTicket(ticket3);


Console.ReadKey();
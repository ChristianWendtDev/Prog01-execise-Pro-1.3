// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double netPriceBook = 30;
double netPriceDVD = 50;
double netPriceGame = 100;

int noOfBooksInOrder = 8;
int noOfDVDsInOrder = 3;
int noOfGamesInOrder = 2;

double totalNetPrice = netPriceBook * noOfBooksInOrder +
					   netPriceDVD * noOfDVDsInOrder +
					   netPriceGame * noOfGamesInOrder;

int booksDVDs = noOfBooksInOrder + noOfDVDsInOrder;

// SO#1 minimum purchase 1000
bool receiveSpecialOffer1 = (totalNetPrice > 1000);

// SO#2 bought more books than games
bool receiveSpecialOffer2 = noOfBooksInOrder > noOfDVDsInOrder;

// SO#3 bought minimum 10 of 1 item
bool receiveSpecialOffer3 = (noOfBooksInOrder >= 10 ||  noOfDVDsInOrder >= 10 || noOfGamesInOrder >= 10);

// SO#4
bool receiveSpecialOffer4 = (booksDVDs < 10) && (booksDVDs >= 20) || noOfGamesInOrder <=5; 


Console.WriteLine($"You ordered {noOfBooksInOrder} books, " +
				  $"{noOfDVDsInOrder} DVDs and " +
				  $"{noOfGamesInOrder} games");

Console.WriteLine($"You qualify for special offer #1 : {receiveSpecialOffer1}");
Console.WriteLine($"You qualify for special offer #2 : {receiveSpecialOffer2}");
Console.WriteLine($"You qualify for special offer #3 : {receiveSpecialOffer3}");
Console.WriteLine($"You qualify for special offer #4 : {receiveSpecialOffer4}");
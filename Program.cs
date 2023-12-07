/*  
* You work for a company that makes products that come off a conveyor belt. As each of these items  
* reach the end of the belt, they get placed into a shipping box that can hold a maximum of 10  
* items. The shipping box cannot weigh more than 20kg and the items are supposed to be 2kg each.  
* However, due to imperfections in the manufacturing process each item's weight ranges between +/- 1kg. 
* You know each item's weight as they come off the conveyor belt. The weights are rounded to the closest 
* kilo. Fill the shipping boxes with items. 
* The company wants a report that includes:  
* - How many shipping boxes are needed.  
* - How many shipping boxes are not 100% full?  
* - Of those non-full shipping boxes what is the total number of items that were not able to be placed  
* into them?  
*/

// [3, 2, 2, 2, 3, 2, 2, 3, 1, 2, 3, 2, 3, 1, 1, 2, 2, 3, 2, 3, 1, 1, 2, 3, 2, 2, 1, 2, 1, 3, 1, 1, 3, 1, 1, 2, 3, 2, 2, 3]

using System;
using System.Linq;
using System.Collections.Generic;

// Setup Product Dataset
var products = new int[] { 3, 2, 2, 2, 3, 2, 2, 3, 1, 2, 3, 2, 3, 1, 1, 2, 2, 3, 2, 3, 1, 1, 2, 3, 2, 2, 1, 2, 1, 3, 1, 1, 3, 1, 1, 2, 3, 2, 2, 3 };

// Setup Shipping Box Collections
var shippingBoxes = new List<List<int>>();
var shippingBox = new List<int>(10);

Console.WriteLine(string.Empty);
Console.WriteLine($"**************************");
Console.WriteLine($"** Conveyor Belt Output **");
Console.WriteLine($"**************************");
Console.WriteLine(string.Empty);

foreach (var product in products)
{
    if (shippingBox.Count < 10 && shippingBox.Sum() + product <= 20)
    {
        shippingBox.Add(product);

        Console.WriteLine($"Box: {shippingBoxes.Count + 1} - Item: {shippingBox.Count} - Weight: {shippingBox.Sum()}");
    }
    else
    {
        // Add Used Shipping Box to Collection
        shippingBoxes.Add(shippingBox);

        // Add Current Product to New Shipping Box
        shippingBox = [product];

        Console.WriteLine(string.Empty);
        Console.WriteLine($"Box: {shippingBoxes.Count + 1} - Item: {shippingBox.Count} - Weight: {shippingBox.Sum()}");
    }
}

// Add the Last Shipping Box to Collection
shippingBoxes.Add(shippingBox);

// Final Report Output
Console.WriteLine(string.Empty);
Console.WriteLine($"**************************");
Console.WriteLine($"****** Final Report ******");
Console.WriteLine($"**************************");
Console.WriteLine(string.Empty);

Console.WriteLine($"Total Number of Boxes: {shippingBoxes.Count}");
Console.WriteLine($"Total Number of Full Boxes: {shippingBoxes.Count(sb => sb.Count == 10)}");
Console.WriteLine($"Total Number of Spaces in Boxes: {shippingBoxes.Where(sb => sb.Count < 10).Sum(sb => 10 - sb.Count)}");
Console.WriteLine(string.Empty);

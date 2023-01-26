# PathfindingDemo
 A Forms application that draws a randomized node map and then finds the shortest path from X to Y using the selected algorithm - currently Dijkstra's MST or A*.

## How to use

On the top row there are some settings you can play around with.     
* Nodes (the total amount of nodes/points to draw - and then path through)
* Branching (the maximum amount of branches a single point can have)
* Seed (the seed from which the "map" is randomly generated)
* Random Costs (instead of calculating the travel cost of each node, they're instead assigned a random one)

Once you've set the settings how you want you simply press one of the two buttons in the top right corner, labeled **Dijkstra** and **A***. The program will then run. As of now there is no indication that it is indeed running - the process will take a few seconds, and once it's done it will draw the map, and then the shortest path between the two randomly selected points, according to the chosen algorithm (highlighted with green for the path, and orange for the points).




## Example

![Example using A*](https://i.imgur.com/Jl5lF8G.png)

## License

[MIT](https://choosealicense.com/licenses/mit/)


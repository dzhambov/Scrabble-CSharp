# _Scrabble Score Game_

#### _Fun game to practice testing in C#, March 5th 2020_

#### By _**Hristo Dzhambov**_

## Description
 _Scrabble Score game takes a user input word and translates it into a score in the following fashion:_

## Preview

![Landing Page Preview](https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcT767D5rYsTdGIv5dhKVsx3Jc3rL-alS3mH_hVwe6FJE-XKKPUt)

| Letters | Score for the Letters|
|--------| :------------------:|
|A, E, I, O, U, L, N, R, S, T | 1  |
|D, G | 2  |
| B, C, M, P   |  3 |
| F, H, V, W, Y   |  4 |
| K  | 5  |
| J, X  | 8  |
| Q, Z   | 10  |



## Project Specifications

| Behavior | Input | Output |
|---|:---:|:---:|
|User inputs the ingredients they have and clicks submit to recieve recipe inspiration|apple, sugar, flour|Apple fritter|
|User inputs recipe name to recieve recipe instructions|apple fritter|Combine flour, sugar, salt, baking powder, cinnamon. Stir in milk and egg until just combined. Fold in apple...|
|User clicks on fridge graphic to recieve a food related fact|graphic click|Cherries are in the rose family|

## Setup/Installation Requirements

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
```cd desktop```
* Clone the file from GitHub with HTTPS
```git clone https://github.com/benjamin-thompdx/kitchen-quest.git```
* Open file in your preferred text editor
* On Mac: ```open -a {your text editor} kitchen-quest```
* On Windows: ```kitchen-quest```
* run:  ```npm install```

_Download Manually:_

* Navigate to https://github.com/benjamin-thompdx/kitchen-quest.
* Click the green "Clone or Download" button.
* Click "Download ZIP".
* Click downloaded file to unzip.
* Open folder called "kitchen-quest".
* Right-click "index.html" and select your preferred browser or text editor.

_Note For Editors:_ 
* Once cloned/downloaded, to run and make changes, in the terminal simply run **$ npm install** to download necessary dependencies
* Run **$ npm run build** to create your dist folder with a bundle.js file
* Obtain API key from https://spoonacular.com/food-api
* Create .env file in the root directory of kitchen-quest
* Add the API keys to .env file (```API_KEY = input your API key here```)
* **IMPORTANT** Add .env file to .gitignore file 
* The API key will now be referenced within the kitchen-service.js file using the following syntax: ```${process.env.API_KEY}```
* Lastly, run **$ npm run start** to run the application

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/benjamin-thompdx/kitchen-quest/issues) here on GitHub._

## Technologies Used

* HTML
* CSS
* Bootstrap
* Javascript
* jQuery
* Webpack
* Node.js
* Spoonacular API
* Google custom search engine
* PixelArt

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Team Kitchen Quest_**
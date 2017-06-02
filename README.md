# _Word Counter_

#### _June 02, 2017_

#### By _**David Rolfs**_

## Description



## Setup/Installation Requirements

* Go to Github repository page https://github.com/DavidRolfs/
* Click the "download or clone" button and copy the link.
* In your computers terminal type "git clone" & paste the copied link.
* Once downloaded enter dnx kestrel into your teminal.
* Open web browser of your choice and go to http://localhost:5004/ to view root page.

## Specs
| Description | Input | Output |
|-------------| ------|--------|
| User enters a word into a form. When submitted the page returns what they entered | "hello" | hello |
| user enters multiple words into a second form and when submitted the next page displays the sentence | "hello world" | hello world |
| A method takes the sentence and splits it into any array by each word | "hello world" | ["hello", "world"] |
| A method will loop through the array and will return how many times the individual word was used in the sentence. | single word: "hello", sentence: "hello world" | 1 |
| The method will count if the word was used multiple times | "hello world hello" | 2 |
| Method will ignore capitalization differences | single: "hello" sentence: "HeLlo world hELLo" | 2 |
| Program will ignore punctuation | "hello", "hello world hello!" | 2 |

## Known Bugs
none

## Support and contact details

rolfs97@yahoo.com

## Technologies Used

C#, Nancy, HTML, CSS, Bootstrap, Razor, .Net
### License

MIT

Copyright (c) 2017 **_David Rolfs_**

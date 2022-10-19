Feature: SpecFlowFeature1
Scenario Outline: Roman Tests
	Given input of number <rawinput>
	When converted to Roman numerals
	Then Result should be Romanlanguage "<stringform>"
Examples: 

| rawinput | stringform         |
| 3        |iii                 |
| 4        | iv                 |
| 5        | v                  |
| 6        | vi                 |
| 8        | viii               |
| 9        | ix                 |
| 10       | x                  |
| 11       | xi                 |
| 27       | xxvii              |
| 29       | xxix               |
| 30       | xxx                |
| 31       | xxxi               |
| 777      | dcclxxvii          |
| 999      | cmxcix             |
| 1999     | mcmxcix            |
| 2021     | mmxxi              |
| 4000     | *throws exception* |
| 0        | BLANK              |
| -1       | *throws exception* |
| -100     | *throws exception* |
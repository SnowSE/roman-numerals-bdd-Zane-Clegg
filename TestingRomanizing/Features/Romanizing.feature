Feature: SpecFlowFeature1
Scenario Outline: Roman Tests
	Given input of number <rawinput>
	When converted to Roman numerals
	Then Result should be Romanlanguage "<stringform>"
Examples: 

| rawinput | stringform | junk |
| 3        | iii        |      |
| 4        | iv         |      |
# WoT.Replays
Parsing and analyzing replay files.

## What I know so far
 - files contain one or more json blocks and one binary block
 - file format looks like this
 - 4 byte magic number
 - 4 byte json block count = n
 - 4 byte json block length = l
 - json string block of lengh l
 - repeat for n blocks
 - binary data - ignored for now
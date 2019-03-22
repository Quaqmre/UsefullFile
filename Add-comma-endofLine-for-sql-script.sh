#!/bin/bash
# Delete all containers
while read line;do 
echo $line >> aa.txt
printf "," >>aa.txt
done < a.txt

#Line by Line variable in the a.txt ,U can ADD comma

#!/bin/bash
# Delete all containers
while read line;do 
    while read linee;do
        i=0;
        if ( ( line==linee ) );then
            i= ( ( i+1 ) ) 
            if ( ( i==2 ) ) ;then
                echo "alert"
            fi
        fi
    done
done < asd.txt

#Line by Line variable in the a.txt ,U can ADD comma

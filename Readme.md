## Find the nearest neighbours in a 2D space

In a given set of coordinates, find the nearest n # of neighbour coordinates

Try to compare the performance of the algorithms

### Saple Results

#### Comparison of the execution

|No. of Points In the Space|No. of Neighbours to Find|Given Point|BruteForce - results|BruteForce - time|Optmised - results|Optmised - time|
|-----------|-----------|-----------|-----------|-----------|-----------|-----------|
|1000000|3|(1715,-1387)|(1717,-1386),(1712,-1387),(1710,-1384)|521.5266|(1717,-1386),(1712,-1387),(1710,-1384)|40.9939|
|2000000|3|(-1012,-1742)|(-1013,-1743),(-1014,-1743),(-1010,-1744)|847.1663|(-1013,-1743),(-1014,-1743),(-1010,-1744)|54.6879|
|3000000|3|(1950,-1698)|(1949,-1699),(1951,-1699),(1948,-1699)|1258.8426|(1949,-1699),(1951,-1699),(1948,-1699)|69.372|
|4000000|3|(-1986,-1516)|(-1985,-1516),(-1986,-1515),(-1987,-1515)|1496.8691|(-1985,-1516),(-1986,-1515),(-1987,-1515)|100.7421|
|5000000|3|(410,-1698)|(409,-1698),(409,-1698),(409,-1699)|1840.2335|(409,-1698),(409,-1698),(409,-1699)|178.6058|
|6000000|3|(-660,1184)|(-659,1184),(-659,1185),(-661,1183)|2290.186|(-659,1184),(-659,1185),(-661,1183)|183.9281|
|7000000|3|(1065,-1582)|(1064,-1582),(1064,-1583),(1064,-1583)|2685.6548|(1064,-1582),(1064,-1583),(1064,-1583)|197.8032|
|8000000|3|(1513,1476)|(1514,1476),(1514,1476),(1512,1477)|3307.4893|(1514,1476),(1514,1476),(1512,1477)|207.7918|
|9000000|3|(-1541,-1025)|(-1542,-1025),(-1540,-1025),(-1541,-1026)|3995.8309|(-1542,-1025),(-1540,-1025),(-1541,-1026)|315.0816|
|10000000|3|(-1296,-1453)|(-1295,-1453),(-1296,-1454),(-1297,-1453)|4786.2292|(-1295,-1453),(-1296,-1454),(-1297,-1453)|264.9886|


### Feedback
If you see a better way to improve the algorithm, let me know.
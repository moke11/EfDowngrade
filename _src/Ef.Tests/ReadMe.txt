CustomerPlugin and SiteTrafficPlugin represent two different EF contexts 
that might want to add schema to the database.  Both, one or ther other, or neither 
can be installed at one time. 

When installed, table schema should be removed.
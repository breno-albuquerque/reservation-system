-- ROLE
insert into [ROLE] 
	([ROLE_NAME], [DATE_INSERTION], [DATE_ALTERATION])
values
	('CLIENT', GetDate(), GetDate()),
	('ADMIN', GetDate(), GetDate())
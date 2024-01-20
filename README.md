# book-manager-asp				
## over view				
	### Compatibility			
		enable book management		
				
	### background			
		book manage is difficult and only one person can edit the file.		
		degreation dose not occur.		
	### purpose			
		everyone can see and edit the file.		
		degreation does not occur.		
				
## functional requirements				
	### account			
		add, edit, delete, authority		
	### login, logout			
	### display list			
		basic, rent, purchase, all		
	### serch			
	### rent			
		application, approval, delete		
	### purchase			
		application, approval, delete		
				
## screen list				
page name , parts, view authority				
	### home			
		title	label	
		number	textbox	
		pass	textbox	
		login	button	
	### main page			
		logout	button	
		display list	button	
		purchase	button	
		edit	button	editor only
	### display list			
		main	button	
		serch text	textbox	
		serch	button	
		category	drop down list	editor only
		list	table	
		rent	button	
		edit book	button	editor only
		purchase	button	editor only
	### rent			
		back	button	
		book info	table	
		loan date	date	
		return date	date	
		application	button	
		approval	drop down list	editor only
		confirm	button	editor only
		delete	button	editor only
	### purchase			
		back	button	
		id	textbox	
		book name	textbox	
		sub title	textbox	
		auther	textbox	
		classification	drop down list	
		target	drop down list	
		price	textbox	
		url	textbox	
		application	button	
		approval	drop down list	editor only
		confirm	button	editor only
		delete	button	editor only
				
	### edit			
		main	button	editor only
		add account	button	editor only
		edit account	button	editor only
		add book	button	editor only
		edit book	button	editor only
				
	### add account			
		back	button	editor only
		number	textbox	editor only
		last name	textbox	editor only
		first name	textbox	editor only
		affiliation	drop down list	editor only
		pass	textbox	editor only
		authority editor	check box	editor only
		confirm	button	editor only
				
	### edit account			
		back	button	editor only
		serch text	textbox	editor only
		serch	button	editor only
		number	textbox	editor only
		last name	textbox	editor only
		first name	textbox	editor only
		affiliation	drop down list	editor only
		pass	textbox	editor only
		authority editor	check box	editor only
		confirm	button	editor only
		delete	button	editor only
				
	### add book			
		back	button	editor only
		id	textbox	editor only
		book name	textbox	editor only
		sub title	textbox	editor only
		auther	textbox	editor only
		classification	drop down list	editor only
		target	drop down list	editor only
		price	textbox	editor only
		url	textbox	editor only
		confirm	button	editor only
				
	### edit book			
		back	button	editor only
		serch text	textbox	editor only
		serch	button	editor only
		id	textbox	editor only
		book name	textbox	editor only
		sub title	textbox	editor only
		auther	textbox	editor only
		classification	drop down list	editor only
		target	drop down list	editor only
		price	textbox	editor only
		url	textbox	editor only
		confirm	button	editor only
		delete	button	editor only
				
## transition diagram				
	home >	< login >	main page >	log out >
				< display list >
				< display list >
				< display list >
				< purchase
				< edit >
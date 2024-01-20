# book-manager-asp						
## over view						
	compatibility					
		enable book management				
						
	background					
		book manage is difficult and only one person can edit the file.				
		degreation dose not occur.				
	purpose					
		everyone can see and edit the file.				
		degreation does not occur.				
						
## functional requirements						
	account					
		add	edit	delete	authority	
	login, logout					
	displayList					
		basic	rent	purchase	all	
	serch					
	rent					
		application	approval	delete		
	purchase					
		application	approval	delete		
						
## screen list						
	pageName	parts	viewAuthority			
	home					
		title	label			
		number	textBox			
		pass	textBox			
		login	button			
	mainPage					
		logout	button			
		displayList	button			
		purchase	button			
		edit	button	editorOnly		
	displayList					
		main	button			
		serchText	textBox			
		serch	button			
		category	dropDownList	editorOnly		
		list	table			
		rent	button			
		editBook	button	editorOnly		
		purchase	button	editorOnly		
	rent					
		back	button			
		bookInfo	table			
		loanDate	date			
		returnDate	date			
		application	button			
		approval	dropDownList	editorOnly		
		confirm	button	editorOnly		
		delete	button	editorOnly		
	purchase					
		back	button			
		id	textBox			
		bookName	textBox			
		subTitle	textBox			
		auther	textBox			
		classification	dropDownList			
		target	dropDownList			
		price	textBox			
		url	textBox			
		application	button			
		approval	dropDownList	editorOnly		
		confirm	button	editorOnly		
		delete	button	editorOnly		
						
	edit					
		main	button	editorOnly		
		addAccount	button	editorOnly		
		editAccount	button	editorOnly		
		addBook	button	editorOnly		
		editBook	button	editorOnly		
						
	addAccount					
		back	button	editorOnly		
		number	textBox	editorOnly		
		lastName	textBox	editorOnly		
		firstName	textBox	editorOnly		
		affiliation	dropDownList	editorOnly		
		pass	textBox	editorOnly		
		authority editor	checkBox	editorOnly		
		confirm	button	editorOnly		
						
	editAccount					
		back	button	editorOnly		
		serchText	textBox	editorOnly		
		serch	button	editorOnly		
		number	textBox	editorOnly		
		lastName	textBox	editorOnly		
		firstName	textBox	editorOnly		
		affiliation	dropDownList	editorOnly		
		pass	textBox	editorOnly		
		authority editor	checkBox	editorOnly		
		confirm	button	editorOnly		
		delete	button	editorOnly		
						
	addBook					
		back	button	editorOnly		
		id	textBox	editorOnly		
		bookName	textBox	editorOnly		
		subTitle	textBox	editorOnly		
		auther	textBox	editorOnly		
		classification	dropDownList	editorOnly		
		target	dropDownList	editorOnly		
		price	textBox	editorOnly		
		url	textBox	editorOnly		
		confirm	button	editorOnly		
						
	editBook					
		back	button	editorOnly		
		serchText	textBox	editorOnly		
		serch	button	editorOnly		
		id	textBox	editorOnly		
		bookName	textBox	editorOnly		
		subTitle	textBox	editorOnly		
		auther	textBox	editorOnly		
		classification	dropDownList	editorOnly		
		target	dropDownList	editorOnly		
		price	textBox	editorOnly		
		url	textBox	editorOnly		
		confirm	button	editorOnly		
		delete	button	editorOnly		
						
## transition diagram						
	home >	< login >	main page >	log out >		
				< displayList >		
				< displayList >		
				< displayList >		
				< purchase		
				< edit >		
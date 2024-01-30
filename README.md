# book-manager-win-form

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
			add		edit		delete		authority
	login, logout
	list display
			basic		rent		purchase	all
	serch
	rent
			application	approval	delete
	purchase
			application	approval	delete

## screen list
	pageName	itemName		itemClass	viewAuthority				
	home							
			Book Manager		label				
			employee number		textBox				
			password		textBox				
			login			button				
	main page page							
			Book Manager		label		
			logout			button				
			list display		button				
			purchase		button				
			edit			button		editorOnly		
	list display							
			main page		button				
			serchText		textBox				
			serch			button				
			category		dropDownList	editorOnly		
			list			table				
			rent			button				
			edit book		button		editorOnly		
			purchase		button		editorOnly		
	rent							
			back			button				
			bookInfo		table				
			loan date		date				
			return date		date				
			application		button				
			approval		dropDownList	editorOnly		
			confirm			button		editorOnly		
			delete			button		editorOnly		
	purchase							
			back			button				
			id			textBox				
			bookName		textBox				
			subTitle		textBox				
			auther			textBox				
			classification		dropDownList				
			target			dropDownList				
			price			textBox				
			url			textBox				
			application		button				
			approval		dropDownList	editorOnly		
			confirm			button		editorOnly		
			delete			button		editorOnly		
								
	edit							
			main page		button		editorOnly		
			add account		button		editorOnly		
			edit account		button		editorOnly		
			add book		button		editorOnly		
			edit book		button		editorOnly		
								
	add account							
			back			button		editorOnly		
			employee number		textBox		editorOnly		
			lastName		textBox		editorOnly		
			firstName		textBox		editorOnly		
			affiliation		dropDownList	editorOnly		
			password		textBox		editorOnly		
			editor			checkBox	editorOnly		
			confirm			button		editorOnly		
								
	edit account							
			back			button		editorOnly		
			serchText		textBox		editorOnly		
			serch			button		editorOnly		
			employee number		textBox		editorOnly		
			lastName		textBox		editorOnly		
			firstName		textBox		editorOnly		
			affiliation		dropDownList	editorOnly		
			password		textBox		editorOnly		
			editor	checkBox	editorOnly		
			confirm			button		editorOnly		
			delete			button		editorOnly		
								
	add book							
			back			button		editorOnly		
			id			textBox		editorOnly		
			bookName		textBox		editorOnly		
			subTitle		textBox		editorOnly		
			auther			textBox		editorOnly		
			classification		dropDownList	editorOnly		
			target			dropDownList	editorOnly		
			price			textBox		editorOnly		
			url			textBox		editorOnly		
			confirm			button		editorOnly		
								
	edit book							
			back			button		editorOnly		
			serchText		textBox		editorOnly		
			serch			button		editorOnly		
			id			textBox		editorOnly		
			bookName		textBox		editorOnly		
			subTitle		textBox		editorOnly		
			auther			textBox		editorOnly		
			classification		dropDownList	editorOnly		
			target			dropDownList	editorOnly		
			price			textBox		editorOnly		
			url			textBox		editorOnly		
			confirm			button		editorOnly		
			delete			button		editorOnly		
								
## transition diagram								
	home >	< login > main page page >	log out >		 home
						< list display >	 < rent
						< list display >	 < edit book
						< list display >	 < purchase
						< purchase		
						< edit >		 < add account
									 < edit account
									 < add book
									 < edit book
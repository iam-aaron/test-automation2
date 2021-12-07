test:
	dotnet build $(FILE)/$(SOLUTION_FILE)
	dotnet test $(FILE)/$(SOLUTION_FILE)
	mkdir -p $(CURDIR)/artifact
	cd $(FILE); ls
	cd $(FILE)/BSuiteE2ERegressionTestSuite; ls
	
	
	
FLAG1=/nologo
all: acmetest.exe
acmetest.exe:acmetest.cs acme.dll
    csc /out:acmetest.exe \
            acmetest.cs \
            /r:acme.dll \
            $(FLAG1)
acme.dll:acme.cs
    csc /out:$@ /t:library acme.cs $(FLAG1)
	
clean:
    del *.dll
cleanall:clean
    del *.exe
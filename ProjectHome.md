ObsessiveCompulsive is a tool intended to combine multi-step task documentation with an onscreen visual prompting aid.  As a programmer, I try to automate as much as possible via scripts, but some things simply have to be done by hand.  For example, issuing a release for me is currently a 23-step process, combining many automated subtasks with other manual steps and verifications.

I previously used a paper printout of the release procedure as my reference.  The problem was that I tended to skip steps, due to running releases (on several concurrent projects) as often as every few days, and of course being in a hurry.

ObsessiveCompulsive solves that problem in a rather unobtrusive way.  Here are the features that keep me using it regularly:

- Uses ASCII source file format

- Create a **.steps file and double-click it to start the process; a steps file is basically a sequence of text lines with optional whitespace between them.**

- The step prompting window is small, shown semi-transparently on the edge of the screen, and is easily moved.

- Steps files are intended to also function as documentation; since they are actually used by the programmer, they remain 'in your face' and will likely be kept up to date.

- Encourages creating lots of documentation in steps format, which other programmers can follow.

- Text can wrap and contain additional lines of explanations and notes (which are tab or space indented), and the prompting window expands as necessary to show all of it.

- Links embedded in the text are clickable, e.g. http://localhost/test or [file://c|/dev/whatever.bat](file://c|/dev/whatever.bat) .  I use this to launch automated scripts, reference documents, source files, etc.

Try it out!  Hopefully you will like it as much as I do, and/or offer a suggestion to improve it.

To install, you can just download the latest source and run the setup program in the Output folder, which is built with InnoSetup and automatically creates the **.steps file association.  Then create some**.steps files and double-click on one to try it out.  Currently if you just run the executable by itself, the program crashes.  Sorry, it's just not meant to be run that way! ... OK, I'll fix it one of these days.
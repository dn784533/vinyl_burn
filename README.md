# vinyl_burn
Vinyl record cutting software. Requires Windows 10.

This program 'Vinyl Burn' works in conjunction with the Arduino software to enable control of the movement of the cutter head of a record lathe. The software allows a complete record side to be planned, with settings for the sound files to be transferred to disc, groove pitches, inter-track gaps and lock groove stop points. When the 'Cut record' icon is clicked, the software communicates via USB with the Arduino to move the linear rail stepper motor.

The document in the repository 'lathe_guide' should be consulted. That repository contains the Arduino sketch and FreeCAD source from which 3D-printable files (.STL) can be extracted.

Note: For development, the project 'VinylBurnUI' should be set as the startup project within the solution.

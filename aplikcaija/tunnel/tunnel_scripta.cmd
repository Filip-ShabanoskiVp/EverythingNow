@echo off
echo "PRED DA JA STARTUVATE SKRIPTATA TREBA VO NEA DA GI STAVITE"
echo "VASHETO KORISNICHKO IME I LOZINKA ZA TUNELOT."
echo "PO STARTUVANJETO, BAZATA KJE BIDE DOSTAPNA NA PORTA LOCALHOST:9999"
echo "AKO SAKATE DA SLUSHA NA DRUGA PORTA, SMENETE JA SKRIPTATA SOODVETNO"
echo "AKO SAKATE DA STOPIRATE (CTRL+C)"

plink -v -ssh -2 -C -N -L 9999:localhost:5432 -pw 3126be5a t_everythingnow@194.149.135.130



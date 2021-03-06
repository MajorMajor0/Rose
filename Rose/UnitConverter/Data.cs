﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    internal partial class Data
    {
        public const string Units =
//From_1|From_2|From_3|From_4|Base symbol|Base unit|Conversion|Type|Dimension|VALID
@"||||blank|blank|0.0000000000000000E+00|blank|blank|TRUE
ct|||carat_metric|kg|kilogram|2.0000000000000000E-04|mass|M|TRUE
gr|||grain|kg|kilogram|6.4798910000000000E-05|mass|M|TRUE
ozm|||ounce_mass_(avoirdupois)|kg|kilogram|2.8349523125000000E-02|mass|M|TRUE
lbm|||pound_mass_(avoirdupois)|kg|kilogram|4.5359237000000000E-01|mass|M|TRUE
cwt|||hundredweight_(short)|kg|kilogram|4.5359237000000000E+01|mass|M|TRUE
cwt_l|||hundredweight_(long)|kg|kilogram|5.0802345440000000E+01|mass|M|TRUE
tonm|||ton_(short)|kg|kilogram|9.0718474000000000E+02|mass|M|TRUE
ton_l|||ton_(long)|kg|kilogram|1.0160469088000000E+03|mass|M|TRUE
AT|||ton_(assay)|kg|kilogram|2.9166666666666700E-02|mass|M|TRUE
ton_met|||ton_(metric)|kg|kilogram|1.0000000000000000E+03|mass|M|TRUE
dwt|||pennyweight|kg|kilogram|1.5551738400000000E-03|mass|M|TRUE
ozm_t|||ounce_(troy_or_apothecary)|kg|kilogram|3.1103476800000000E-02|mass|M|TRUE
lbm_t|||pound_mass_(troy_or_apothecary)|kg|kilogram|3.7324172160000000E-01|mass|M|TRUE
slug|||slug|kg|kilogram|1.4593903000000000E+01|mass|M|TRUE
Yg|||yottagram|kg|kilogram|1.0000000000000000E+21|mass|M|TRUE
Zg|||zettagram|kg|kilogram|1.0000000000000000E+18|mass|M|TRUE
Eg|||exagram|kg|kilogram|1.0000000000000000E+15|mass|M|TRUE
Pg|||petagram|kg|kilogram|1.0000000000000000E+12|mass|M|TRUE
Tg|||teragram|kg|kilogram|1.0000000000000000E+09|mass|M|TRUE
Gg|||gigagram|kg|kilogram|1.0000000000000000E+06|mass|M|TRUE
Mg|||megagram|kg|kilogram|1.0000000000000000E+03|mass|M|TRUE
kg|||kilogram|kg|kilogram|1.0000000000000000E+00|mass|M|TRUE
hg|||hectogram|kg|kilogram|1.0000000000000000E-01|mass|M|TRUE
dag|||decagram|kg|kilogram|1.0000000000000000E-02|mass|M|TRUE
g|||gram|kg|kilogram|1.0000000000000000E-03|mass|M|TRUE
dg|||decigram|kg|kilogram|1.0000000000000000E-04|mass|M|TRUE
cg|||centigram|kg|kilogram|1.0000000000000000E-05|mass|M|TRUE
mg|||milligram|kg|kilogram|1.0000000000000000E-06|mass|M|TRUE
ug|||microgram|kg|kilogram|1.0000000000000000E-09|mass|M|TRUE
ng|||nanogram|kg|kilogram|1.0000000000000000E-12|mass|M|TRUE
pg|||picogram|kg|kilogram|1.0000000000000000E-15|mass|M|TRUE
fg|||femtogram|kg|kilogram|1.0000000000000000E-18|mass|M|TRUE
ag|||attogram|kg|kilogram|1.0000000000000000E-21|mass|M|TRUE
zg|||zeptogram|kg|kilogram|1.0000000000000000E-24|mass|M|TRUE
yg|||yoctogram|kg|kilogram|1.0000000000000000E-27|mass|M|TRUE
shake|||shake|s|second|1.0000000000000000E-08|time|t|TRUE
jiffy|||jiffy|s|second|1.6666666666666700E-02|time|t|TRUE
s|sec||second|s|second|1.0000000000000000E+00|time|t|TRUE
min|||minute|s|second|6.0000000000000000E+01|time|t|TRUE
h|hr||hour|s|second|3.6000000000000000E+03|time|t|TRUE
d|||day|s|second|8.6400000000000000E+04|time|t|TRUE
wk|||week|s|second|6.0480000000000000E+05|time|t|TRUE
fortnight|||fortnight|s|second|1.2096000000000000E+06|time|t|TRUE
yr|y||year|s|second|3.1536000000000000E+07|time|t|TRUE
s_sid|||second_(sidereal)|s|second|9.9726960000000000E-01|time|t|FALSE
min_sid|||minute_(sidereal)|s|second|5.9836176000000000E+01|time|t|TRUE
h_sid|||hour_(sidereal)|s|second|3.5901705600000000E+03|time|t|TRUE
d_sid|||day_(sidereal)|s|second|8.6164093440000000E+04|time|t|TRUE
yr_sid|y_sid||year_(sidereal)|s|second|1.3104122544000000E+06|time|t|TRUE
yr_trop|y_trop||year_(tropical)|s|second|3.1556930000000000E+07|time|t|FALSE
deg|||degree|arcrad|radian|1.7453292519943300E-02|angle|a|TRUE
gon|grade||gon_(grade)|arcrad|radian|1.5707963267949000E-02|angle|a|TRUE
arcmil|||mil_of_arc|arcrad|radian|9.8174770424681000E-04|angle|a|TRUE
arcsec|||second_of_arc|arcrad|radian|4.8481368110953600E-06|angle|a|TRUE
arcmin|||minute_of_arc|arcrad|radian|2.9088820866572200E-04|angle|a|TRUE
arcrad|||radian|arcrad|radian|1.0000000000000000E+00|angle|a|TRUE
rev|r||revolution|arcrad|radian|6.2831853071795900E+00|angle|a|TRUE
K|||kelvin|K|kelvin|1.0000000000000000E+00|temperature|T|TRUE
C|||celsius|K|kelvin|1.0000000000000000E+00|temperature|T|TRUE
F|degF|øF|fahrenheit|K|kelvin|5.5555555555555600E-01|temperature|T|TRUE
R|degR|øR|rankine|K|kelvin|5.5555555555555600E-01|temperature|T|TRUE
uin|||microinch|m|meter|2.5400000000000000E-08|length|L|TRUE
mil|||mil|m|meter|2.5400000000000000E-05|length|L|TRUE
in|||inch|m|meter|2.5400000000000000E-02|length|L|TRUE
ft|||foot|m|meter|3.0480000000000000E-01|length|L|TRUE
yd|||yard|m|meter|9.1440000000000000E-01|length|L|TRUE
ftm|||fathom|m|meter|1.8288000000000000E+00|length|L|TRUE
rod|perch|pole|rod|m|meter|5.0292000000000000E+00|length|L|TRUE
ch|||chain|m|meter|2.0116800000000000E+01|length|L|TRUE
fl|||furlong|m|meter|2.0116800000000000E+02|length|L|TRUE
mi|||mile|m|meter|1.6093440000000000E+03|length|L|TRUE
ft_uss|||foot_(us_survey)|m|meter|3.0480060000000000E-01|length|L|TRUE
yd_uss|||yard_(us_survey)|m|meter|9.1440180000000000E-01|length|L|TRUE
ftm_uss|||fathom_(us_survey)|m|meter|1.8288036000000000E+00|length|L|TRUE
rod_uss|||rod_(us_survey_foot)|m|meter|5.0292099000000000E+00|length|L|TRUE
ch_uss|||chain_(us_survey)|m|meter|2.0116839600000000E+01|length|L|TRUE
fl_uss|||furlong_(us_survey)|m|meter|2.0116839600000000E+02|length|L|TRUE
mi_uss|||mile_(us_survey)|m|meter|1.6093471680000000E+03|length|L|TRUE
mi_naut|||mile_(nautical)|m|meter|1.8520000000000000E+03|length|L|TRUE
AU|au||astronomical_unit|m|meter|1.4959787070000000E+11|length|L|TRUE
ly|||light_year|m|meter|9.4607304725808000E+15|length|L|TRUE
pc|||parsec|m|meter|3.0856775814913700E+16|length|L|TRUE
twip|||twip_(printer)|m|meter|1.7568333333333300E-05|length|L|TRUE
point|||point_(printer)|m|meter|3.5136666666666700E-04|length|L|TRUE
pica|||pica_(printer)|m|meter|4.2164000000000000E-03|length|L|TRUE
point_cpu|||point_(computer)|m|meter|3.5277777777777800E-04|length|L|TRUE
pica_cpu|||pica_(computer)|m|meter|4.2333333333333300E-03|length|L|TRUE
point_fr|dd||point_(french)|m|meter|3.7600000000000000E-04|length|L|TRUE
pica_fr|cicero||pica_(french)|m|meter|4.5120000000000000E-03|length|L|TRUE
Ym|||yottameter|m|meter|1.0000000000000000E+24|length|L|TRUE
Zm|||zettameter|m|meter|1.0000000000000000E+21|length|L|TRUE
Em|||exameter|m|meter|1.0000000000000000E+18|length|L|TRUE
Pm|||petameter|m|meter|1.0000000000000000E+15|length|L|TRUE
Tm|||terameter|m|meter|1.0000000000000000E+12|length|L|TRUE
Gm|||gigameter|m|meter|1.0000000000000000E+09|length|L|TRUE
Mm|||megameter|m|meter|1.0000000000000000E+06|length|L|TRUE
km|||kilometer|m|meter|1.0000000000000000E+03|length|L|TRUE
hm|||hectometer|m|meter|1.0000000000000000E+02|length|L|TRUE
dam|||decameter|m|meter|1.0000000000000000E+01|length|L|TRUE
m|||meter|m|meter|1.0000000000000000E+00|length|L|TRUE
dm|||decimeter|m|meter|1.0000000000000000E-01|length|L|TRUE
cm|||centimeter|m|meter|1.0000000000000000E-02|length|L|TRUE
mm|||millimeter|m|meter|1.0000000000000000E-03|length|L|TRUE
um|micron||micrometer|m|meter|1.0000000000000000E-06|length|L|TRUE
nm|||nanometer|m|meter|1.0000000000000000E-09|length|L|TRUE
pm|fermi||picometer|m|meter|1.0000000000000000E-12|length|L|TRUE
fm|||femtometer|m|meter|1.0000000000000000E-15|length|L|TRUE
am|||attometer|m|meter|1.0000000000000000E-18|length|L|TRUE
zm|||zeptometer|m|meter|1.0000000000000000E-21|length|L|TRUE
ym|||yoctometer|m|meter|1.0000000000000000E-24|length|L|TRUE
|||†ngstr”m|m|meter|1.0000000000000000E-10|length|L|TRUE
rood|||rood_(international)|m2|square meter|1.0117141056000000E+03|area|L^2|FALSE
ac|||acre_(international)|m2|square meter|4.0468564224000000E+03|area|L^2|TRUE
ac_uss|||acre_(us_survey_foot)|m2|square meter|4.0468726098742500E+03|area|L^2|TRUE
ca|||centare|m2|square meter|1.0000000000000000E+00|area|L^2|TRUE
a|||are|m2|square meter|1.0000000000000000E+02|area|L^2|TRUE
ha|||hectare|m2|square meter|1.0000000000000000E+04|area|L^2|TRUE
b|||barn|m2|square meter|1.0000000000000000E-28|area|L^2|TRUE
cmil|||circular_mil|m2|square meter|5.0670747909749800E-04|area|L^2|TRUE
ac ft|||acre-foot|m3|cubic meter|1.2334818375475200E+03|volume|L^3|TRUE
ac ft_uss|||acre-foot_(us_survey_foot)|m3|cubic meter|1.2334891996132400E+03|volume|L^3|TRUE
dram|||dram|m3|cubic meter|3.6966911953125000E-06|volume|L^3|TRUE
tsp|||teaspoon|m3|cubic meter|4.9289215937500000E-06|volume|L^3|TRUE
tblsp|||tablespoon|m3|cubic meter|1.4786764781250000E-05|volume|L^3|TRUE
oz|||fluid_ounce_(US)|m3|cubic meter|2.9573529562500000E-05|volume|L^3|TRUE
gi|||gill_(US)|m3|cubic meter|1.1829411825000000E-04|volume|L^3|TRUE
cup|||cup_(US)|m3|cubic meter|2.3658823650000000E-04|volume|L^3|TRUE
pt|||pint_(US_liquid)|m3|cubic meter|4.7317647300000000E-04|volume|L^3|TRUE
qt|||quart_(US_liquid)|m3|cubic meter|9.4635294600000000E-04|volume|L^3|TRUE
gal|||gallon_(US_liquid)|m3|cubic meter|3.7854117840000000E-03|volume|L^3|TRUE
RT|GRT|ton_reg|register_ton|m3|cubic meter|2.8316846592000000E+00|volume|L^3|TRUE
oz_uk|oz_can|oz_imp|fluid_ounce_(Canadian_and_UK_Imperial)|m3|cubic meter|2.8413062500000000E-05|volume|L^3|TRUE
gi_uk|gi_can|gi_imp|gill_(Canadian_and_UK_Imperial)|m3|cubic meter|1.4206531250000000E-04|volume|L^3|TRUE
pt_uk|pt_can|pt_imp|pint_(Canadian_and_UK_Imperial)|m3|cubic meter|5.6826125000000000E-04|volume|L^3|TRUE
qt_uk|qt_cam|qt_imp|quart_(Canadian_and_UK_Imperial)|m3|cubic meter|1.1365225000000000E-03|volume|L^3|TRUE
gal_uk|gal_can|gal_imp|gallon_(Canadian_and_UK_Imperial)|m3|cubic meter|4.5460900000000000E-03|volume|L^3|TRUE
gal_uk_wine|wine_gallon||gallon_(UK_wine)|m3|cubic meter|3.7854117840000000E-03|volume|L^3|TRUE
rundlet|||rundlet|m3|cubic meter|6.8137412112000000E-02|volume|L^3|TRUE
barrel_uk_wine|||barrel_(UK_wine)|m3|cubic meter|1.1924047119600000E-01|volume|L^3|TRUE
tierce|||tierce|m3|cubic meter|1.5898729492800000E-01|volume|L^3|TRUE
hogshead_wine|||hogshead_(UK_wine)|m3|cubic meter|2.3848094239200000E-01|volume|L^3|TRUE
puncheon|tertian||puncheon|m3|cubic meter|3.1797458985600000E-01|volume|L^3|TRUE
pipe|butt||pipe|m3|cubic meter|4.7696188478400000E-01|volume|L^3|TRUE
tun|||tun|m3|cubic meter|9.5392376956800000E-01|volume|L^3|TRUE
gal_uk_ale|ale_gallon||gallon_(UK_ale)|m3|cubic meter|4.6211520480000000E-03|volume|L^3|TRUE
firkin|||firkin|m3|cubic meter|4.0914810000000000E-02|volume|L^3|TRUE
kilderkin|||kilderkin|m3|cubic meter|8.1829620000000000E-02|volume|L^3|TRUE
barrel_uk_ale|||barrel_(UK_ale)|m3|cubic meter|1.6365924000000000E-01|volume|L^3|TRUE
hogshead_ale|||hogshead_(UK_ale)|m3|cubic meter|2.4548886000000000E-01|volume|L^3|TRUE
pt_dry|||pint_(US_dry)|m3|cubic meter|5.5061047135750000E-04|volume|L^3|TRUE
qt_dry|||quart_(US_dry)|m3|cubic meter|1.1012209427150000E-03|volume|L^3|TRUE
gal_dry|||gallon_(US_dry)|m3|cubic meter|4.4048837708600000E-03|volume|L^3|TRUE
pk|peck||peck_(US)|m3|cubic meter|8.8097675417200000E-03|volume|L^3|TRUE
bu|bushel||bushel_(US)|m3|cubic meter|3.5239070166880000E-02|volume|L^3|TRUE
cord|||cord|m3|cubic meter|3.6245563637760000E+00|volume|L^3|TRUE
bbl|||barrel_(petroleum_42_gallons_US)|m3|cubic meter|1.5898729492800000E-01|volume|L^3|TRUE
YL|Yl||yottaliter|m3|cubic meter|1.0000000000000000E+21|volume|L^3|TRUE
ZL|Zl||zettaliter|m3|cubic meter|1.0000000000000000E+18|volume|L^3|TRUE
EL|El||exaliter|m3|cubic meter|1.0000000000000000E+15|volume|L^3|TRUE
PL|Pl||petaliter|m3|cubic meter|1.0000000000000000E+12|volume|L^3|TRUE
TL|Tl||teraliter|m3|cubic meter|1.0000000000000000E+09|volume|L^3|TRUE
GL|Gl||gigaliter|m3|cubic meter|1.0000000000000000E+06|volume|L^3|TRUE
ML|Ml||megaliter|m3|cubic meter|1.0000000000000000E+03|volume|L^3|TRUE
kL|kl||kiloliter|m3|cubic meter|1.0000000000000000E+00|volume|L^3|TRUE
hL|hl||hectoliter|m3|cubic meter|1.0000000000000000E-01|volume|L^3|TRUE
daL|dal||decaliter|m3|cubic meter|1.0000000000000000E-02|volume|L^3|TRUE
L|l||liter|m3|cubic meter|1.0000000000000000E-03|volume|L^3|TRUE
dL|dl||deciliter|m3|cubic meter|1.0000000000000000E-04|volume|L^3|TRUE
cL|cl||centiliter|m3|cubic meter|1.0000000000000000E-05|volume|L^3|TRUE
mL|ml||milliliter|m3|cubic meter|1.0000000000000000E-06|volume|L^3|TRUE
uL|ul||microliter|m3|cubic meter|1.0000000000000000E-09|volume|L^3|TRUE
nL|nl||nanoliter|m3|cubic meter|1.0000000000000000E-12|volume|L^3|TRUE
pL|pl||picoliter|m3|cubic meter|1.0000000000000000E-15|volume|L^3|TRUE
fL|fl||femtoliter|m3|cubic meter|1.0000000000000000E-18|volume|L^3|TRUE
aL|al||attoliter|m3|cubic meter|1.0000000000000000E-21|volume|L^3|TRUE
zL|zl||zeptoliter|m3|cubic meter|1.0000000000000000E-24|volume|L^3|TRUE
yL|yl||yoctoliter|m3|cubic meter|1.0000000000000000E-27|volume|L^3|TRUE
ips|||inch_per_second|m/s|meter per second|2.5400000000000000E-02|velocity|L / t|TRUE
ipm|||inch_per_minute|m/s|meter per second|4.2333333333333300E-04|velocity|L / t|TRUE
iph||in/hr|inch_per_hour|m/s|meter per second|7.0555555555555600E-06|velocity|L / t|TRUE
fps|||foot_per_second|m/s|meter per second|3.0480000000000000E-01|velocity|L / t|TRUE
fpm|||foot_per_minute|m/s|meter per second|5.0800000000000000E-03|velocity|L / t|TRUE
fph||ft/hr|foot_per_hour|m/s|meter per second|8.4666666666666700E-05|velocity|L / t|TRUE
mps|||mile_per_second|m/s|meter per second|1.6093440000000000E+03|velocity|L / t|TRUE
mpm|||mile_per_minute|m/s|meter per second|2.6822400000000000E+01|velocity|L / t|TRUE
mph|||mile_per_hour|m/s|meter per second|4.4704000000000000E-01|velocity|L / t|TRUE
kmh|||kilometer_per_hour|m/s|meter per second|2.7777777777777800E-01|velocity|L / t|TRUE
nmph|||knot|m/s|meter per second|5.1444444444444400E-01|velocity|L / t|TRUE
rpm|RPM||revolution_per_minute|arcrad/s|arcrad per second|1.0471975511966000E-01|angular velocity|a / t|TRUE
rps|RPS||revolution_per_second|arcrad/s|arcrad per second|6.2831853071795900E+00||a / t|TRUE
Hz|Hz||Hertz|arcrad/s|arcrad per second|6.2831853071795900E+00||a / t|TRUE
gn|gc||standard_gravity|m/s2|meter per second squared|9.8066500000000000E+00|acceleration|L/t^2|TRUE
Gal|galileo||gal|m/s2|meter per second squared|1.0000000000000000E-02|acceleration|L/t^2|TRUE
ozf|oz||ounce_force_(avoirdupois)|N|newton|2.7801385095378100E-01|force|M L / t^2|TRUE
lbf|lb||pound_force_(avoirdupois)|N|newton|4.4482216152605000E+00|force|M L / t^2|TRUE
kip|klbf||kilopound_force|N|newton|4.4482216152605000E+03|force|M L / t^2|TRUE
tonf|ton||ton_force|N|newton|8.8964432305210000E+03|force|M L / t^2|TRUE
dyn|||dyne|N|newton|1.0000000000000000E-05|force|M L / t^2|TRUE
kgf|||kilogram-force|N|newton|9.8066500000000000E+00|force|M L / t^2|TRUE
kp|||kilopond_(kilogram-force)|N|newton|9.8066500000000000E+00|force|M L / t^2|TRUE
pdl|||poundal|N|newton|1.3825495437600000E-01|force|M L / t^2|TRUE
YN|||yottanewton|N|newton|1.0000000000000000E+24|force|M L / t^2|TRUE
ZN|||zettanewton|N|newton|1.0000000000000000E+21|force|M L / t^2|TRUE
EN|||exanewton|N|newton|1.0000000000000000E+18|force|M L / t^2|TRUE
PN|||petanewton|N|newton|1.0000000000000000E+15|force|M L / t^2|TRUE
TN|||teranewton|N|newton|1.0000000000000000E+12|force|M L / t^2|TRUE
GN|||giganewton|N|newton|1.0000000000000000E+09|force|M L / t^2|TRUE
MN|||meganewton|N|newton|1.0000000000000000E+06|force|M L / t^2|TRUE
kN|||kilonewton|N|newton|1.0000000000000000E+03|force|M L / t^2|TRUE
hN|||hectonewton|N|newton|1.0000000000000000E+02|force|M L / t^2|TRUE
daN|||decanewton|N|newton|1.0000000000000000E+01|force|M L / t^2|TRUE
N|||newton|N|newton|1.0000000000000000E+00|force|M L / t^2|TRUE
dN|||decinewton|N|newton|1.0000000000000000E-01|force|M L / t^2|TRUE
cN|||centinewton|N|newton|1.0000000000000000E-02|force|M L / t^2|TRUE
mN|||millinewton|N|newton|1.0000000000000000E-03|force|M L / t^2|TRUE
uN|micron||micronewton|N|newton|1.0000000000000000E-06|force|M L / t^2|TRUE
nN|||nanonewton|N|newton|1.0000000000000000E-09|force|M L / t^2|TRUE
pN|fermi||piconewton|N|newton|1.0000000000000000E-12|force|M L / t^2|TRUE
fN|||femtonewton|N|newton|1.0000000000000000E-15|force|M L / t^2|TRUE
aN|||attonewton|N|newton|1.0000000000000000E-18|force|M L / t^2|TRUE
zN|||zeptonewton|N|newton|1.0000000000000000E-21|force|M L / t^2|TRUE
yN|||yoctonewton|N|newton|1.0000000000000000E-24|force|M L / t^2|TRUE
atm|||atmosphere_standard|N/m2|newton per square meter|1.0132500000000000E+05|pressure|M / L t^2|TRUE
atm_t|||atmosphere_technical|N/m2|newton per square meter|9.8066500000000000E+04|pressure|M / L t^2|TRUE
in_Hg|||inch_of_mercury_(32F)|N/m2|newton per square meter|3.3863886403410000E+03|pressure|M / L t^2|TRUE
ft_Hg|||foot_of_mercury_(32F)|N/m2|newton per square meter|4.0636663684092000E+04|pressure|M / L t^2|TRUE
mm_Hg|||millimeter_of_mercury_(32F)|N/m2|newton per square meter|1.3332238741500000E+02|pressure|M / L t^2|TRUE
cm_Hg|||centimeter_of_mercury_(32F)|N/m2|newton per square meter|1.3332238741500000E+03|pressure|M / L t^2|TRUE
in_Hg_60|||inch_of_mercury_(60F)|N/m2|newton per square meter|3.3768500000000000E+03|pressure|M / L t^2|TRUE
mm_H20|||millimeter_of_water_(4C)|N/m2|newton per square meter|9.8066500000000000E+00|pressure|M/L t^2|FALSE
cm_H20|||centimeter_of_water_(4C)|N/m2|newton per square meter|9.8066500000000000E+01|pressure|M / L t^2|FALSE
in_H20|||inch_of_water_(4C)|N/m2|newton per square meter|2.4908891000000000E+02|pressure|M / L t^2|FALSE
ft_H20|||foot_of_water_(4C)|N/m2|newton per square meter|2.9890669200000000E+03|pressure|M / L t^2|FALSE
cm_H20_c|||centimeter_of_water_conventional|N/m2|newton per square meter|9.8066500000000000E+01|pressure|M / L t^2|TRUE
in_H20_60|||inch_of_water_(60F)|N/m2|newton per square meter|2.4884000000000000E+02|pressure|M / L t^2|FALSE
psi|PSI||pound-force_per_square_inch|N/m2|newton per square meter|6.8947572931683600E+03|pressure|M / L t^2|TRUE
ksi|KSI||kip_per_square_inch|N/m2|newton per square meter|6.8947572931683600E+06|pressure|M / L t^2|FALSE
psf|PSF||pound-force_per_square_foot|N/m2|newton per square meter|4.7880258980335800E+01|pressure|M / L t^2|FALSE
mTorr|||millitorr|N/m2|newton per square meter|1.3332236842105300E-01|pressure|M / L t^2|TRUE
Torr|||torr|N/m2|newton per square meter|1.3332236842105300E+02|pressure|M / L t^2|TRUE
Ybar|||yottabar|N/m2|newton per square meter|1.0000000000000000E+29|pressure|M / L t^2|TRUE
Zbar|||zettabar|N/m2|newton per square meter|1.0000000000000000E+26|pressure|M / L t^2|TRUE
Ebar|||exabar|N/m2|newton per square meter|1.0000000000000000E+23|pressure|M / L t^2|TRUE
Pbar|||petabar|N/m2|newton per square meter|1.0000000000000000E+20|pressure|M / L t^2|TRUE
Tbar|||terabar|N/m2|newton per square meter|1.0000000000000000E+17|pressure|M / L t^2|TRUE
Gbar|||gigabar|N/m2|newton per square meter|1.0000000000000000E+14|pressure|M / L t^2|TRUE
Mbar|||megabar|N/m2|newton per square meter|1.0000000000000000E+11|pressure|M / L t^2|TRUE
kbar|||kilobar|N/m2|newton per square meter|1.0000000000000000E+08|pressure|M / L t^2|TRUE
hbar|||hectobar|N/m2|newton per square meter|1.0000000000000000E+07|pressure|M / L t^2|TRUE
dabar|||decabar|N/m2|newton per square meter|1.0000000000000000E+06|pressure|M / L t^2|TRUE
bar|||bar|N/m2|newton per square meter|1.0000000000000000E+05|pressure|M / L t^2|TRUE
dbar|||decibar|N/m2|newton per square meter|1.0000000000000000E+04|pressure|M / L t^2|TRUE
cbar|||centibar|N/m2|newton per square meter|1.0000000000000000E+03|pressure|M / L t^2|TRUE
mbar|||millibar|N/m2|newton per square meter|1.0000000000000000E+02|pressure|M / L t^2|TRUE
ubar|||microbar|N/m2|newton per square meter|1.0000000000000000E-01|pressure|M / L t^2|TRUE
nbar|||nanobar|N/m2|newton per square meter|1.0000000000000000E-04|pressure|M / L t^2|TRUE
pbar|||picobar|N/m2|newton per square meter|1.0000000000000000E-07|pressure|M / L t^2|TRUE
fbar|||femtobar|N/m2|newton per square meter|1.0000000000000000E-10|pressure|M / L t^2|TRUE
abar|||attobar|N/m2|newton per square meter|1.0000000000000000E-13|pressure|M / L t^2|TRUE
zbar|||zeptobar|N/m2|newton per square meter|1.0000000000000000E-16|pressure|M / L t^2|TRUE
ybar|||yoctobar|N/m2|newton per square meter|1.0000000000000000E-19|pressure|M / L t^2|TRUE
YPa|||yottapascal|N/m2|newton per square meter|1.0000000000000000E+24|pressure|M / L t^2|TRUE
ZPa|||zettapascal|N/m2|newton per square meter|1.0000000000000000E+21|pressure|M / L t^2|TRUE
EPa|||exapascal|N/m2|newton per square meter|1.0000000000000000E+18|pressure|M / L t^2|TRUE
PPa|||petapascal|N/m2|newton per square meter|1.0000000000000000E+15|pressure|M / L t^2|TRUE
TPa|||terapascal|N/m2|newton per square meter|1.0000000000000000E+12|pressure|M / L t^2|TRUE
GPa|||gigapascal|N/m2|newton per square meter|1.0000000000000000E+09|pressure|M / L t^2|TRUE
MPa|||megapascal|N/m2|newton per square meter|1.0000000000000000E+06|pressure|M / L t^2|TRUE
kPa|||kilopascal|N/m2|newton per square meter|1.0000000000000000E+03|pressure|M / L t^2|TRUE
hPa|||hectopascal|N/m2|newton per square meter|1.0000000000000000E+02|pressure|M / L t^2|TRUE
daPa|||decapascal|N/m2|newton per square meter|1.0000000000000000E+01|pressure|M / L t^2|TRUE
Pa|||pascal|N/m2|newton per square meter|1.0000000000000000E+00|pressure|M / L t^2|TRUE
dPa|||decipascal|N/m2|newton per square meter|1.0000000000000000E-01|pressure|M / L t^2|TRUE
cPa|||centipascal|N/m2|newton per square meter|1.0000000000000000E-02|pressure|M / L t^2|TRUE
mPa|||millipascal|N/m2|newton per square meter|1.0000000000000000E-03|pressure|M / L t^2|TRUE
uPa|||micropascal|N/m2|newton per square meter|1.0000000000000000E-06|pressure|M / L t^2|TRUE
nPa|||nanopascal|N/m2|newton per square meter|1.0000000000000000E-09|pressure|M / L t^2|TRUE
pPa|||picopascal|N/m2|newton per square meter|1.0000000000000000E-12|pressure|M / L t^2|TRUE
fPa|||femtopascal|N/m2|newton per square meter|1.0000000000000000E-15|pressure|M / L t^2|TRUE
aPa|||attopascal|N/m2|newton per square meter|1.0000000000000000E-18|pressure|M / L t^2|TRUE
zPa|||zeptopascal|N/m2|newton per square meter|1.0000000000000000E-21|pressure|M / L t^2|TRUE
yPa|||yoctopascal|N/m2|newton per square meter|1.0000000000000000E-24|pressure|M / L t^2|TRUE
BTU|Btu||British_thermal_unit_IT|N m|joule|1.0550558526200000E+03|energy|M L^2 / t^2|TRUE
BTU_th|Btu_th||British_thermal_unit_thermochemical|N m|joule|1.0543502644400000E+03|energy|M L^2 / t^2|TRUE
BTU_m|Btu_m||British_thermal_unit_(mean)|N m|joule|1.0558700000000000E+03|energy|M L^2 / t^2|TRUE
BTU_39F|Btu_39||British_thermal_unit_(39øF)|N m|joule|1.0596700000000000E+03|energy|M L^2 / t^2|TRUE
BTU_59F|Btu_59||British_thermal_unit_(59øF)|N m|joule|1.0548040000000000E+03|energy|M L^2 / t^2|TRUE
BTU_60|Btu_60||British_thermal_unit_(60øF)|N m|joule|1.0546800000000000E+03|energy|M L^2 / t^2|TRUE
therm|||therm_(EC)|N m|joule|1.0550558526200000E+08|energy|M L^2 / t^2|TRUE
therm_us|||therm_(US)|N m|joule|1.0548040000000000E+08|energy|M L^2 / t^2|TRUE
quad|||quad|N m|joule|1.0550558526200000E+18|energy|M L^2 / t^2|TRUE
quad_us|||quad_(US)|N m|joule|1.0596700000000000E+18|energy|M L^2 / t^3|TRUE
cal|||calorie_IT|N m|joule|4.1868000000000000E+00|energy|M L^2 / t^2|TRUE
cal_th|||calorie_th|N m|joule|4.1840000000000000E+00|energy|M L^2 / t^2|TRUE
cal_m|||calorie_(mean)|N m|joule|4.1900200000000000E+00|energy|M L^2 / t^2|FALSE
cal_15C|||calorie_(15øC)|N m|joule|4.1858000000000000E+00|energy|M L^2 / t^2|FALSE
cal_20|||calorie_(20øC)|N m|joule|4.1819000000000000E+00|energy|M L^2 / t^2|FALSE
kcal|||kilocalorie_IT|N m|joule|4.1868000000000000E+03|energy|M L^2 / t^2|TRUE
kcal_th|||kilocalorie_th|N m|joule|4.1840000000000000E+03|energy|M L^2 / t^2|TRUE
kcal_m|||kilocalorie_(mean)|N m|joule|4.1900200000000000E+03|energy|M L^2 / t^2|TRUE
eV|||electron_volt|N m|joule|1.6021765650000000E-19|energy|M L^2 / t^2|TRUE
erg|||erg|N m|joule|1.0000000000000000E-07|energy|M L^2 / t^2|TRUE
kW h|||kilowatt_hour|N m|joule|3.6000000000000000E+06|energy|M L^2 / t^2|TRUE
ton_tnt|||ton_of_TNT|N m|joule|4.1840000000000000E+09|energy|M L^2 / t^2|TRUE
YJ|||yottajoule|N m|joule|1.0000000000000000E+24|energy|M L^2 / t^2|TRUE
ZJ|||zettajoule|N m|joule|1.0000000000000000E+21|energy|M L^2 / t^2|TRUE
EJ|||exajoule|N m|joule|1.0000000000000000E+18|energy|M L^2 / t^2|TRUE
PJ|||petajoule|N m|joule|1.0000000000000000E+15|energy|M L^2 / t^2|TRUE
TJ|||terajoule|N m|joule|1.0000000000000000E+12|energy|M L^2 / t^2|TRUE
GJ|||gigajoule|N m|joule|1.0000000000000000E+09|energy|M L^2 / t^2|TRUE
MJ|||megajoule|N m|joule|1.0000000000000000E+06|energy|M L^2 / t^2|TRUE
kJ|||kilojoule|N m|joule|1.0000000000000000E+03|energy|M L^2 / t^2|TRUE
hJ|||hectojoule|N m|joule|1.0000000000000000E+02|energy|M L^2 / t^2|TRUE
daJ|||decajoule|N m|joule|1.0000000000000000E+01|energy|M L^2 / t^2|TRUE
J|||joule|N m|joule|1.0000000000000000E+00|energy|M L^2 / t^2|TRUE
dJ|||decijoule|N m|joule|1.0000000000000000E-01|energy|M L^2 / t^2|TRUE
cJ|||centijoule|N m|joule|1.0000000000000000E-02|energy|M L^2 / t^2|TRUE
mJ|||millijoule|N m|joule|1.0000000000000000E-03|energy|M L^2 / t^2|TRUE
uJ|||microjoule|N m|joule|1.0000000000000000E-06|energy|M L^2 / t^2|TRUE
nJ|||nanojoule|N m|joule|1.0000000000000000E-09|energy|M L^2 / t^2|TRUE
pJ|||picojoule|N m|joule|1.0000000000000000E-12|energy|M L^2 / t^2|TRUE
fJ|||femtojoule|N m|joule|1.0000000000000000E-15|energy|M L^2 / t^2|TRUE
aJ|||attojoule|N m|joule|1.0000000000000000E-18|energy|M L^2 / t^2|TRUE
zJ|||zeptojoule|N m|joule|1.0000000000000000E-21|energy|M L^2 / t^2|TRUE
yJ|||yoctojoule|N m|joule|1.0000000000000000E-24|energy|M L^2 / t^2|TRUE
hp|||horsepower|N m/s|watt|7.4569987158227000E+02|power|M L^2 / t^3|TRUE
YW|||yottawatt|N m/s|watt|1.0000000000000000E+24|power|M L^2 / t^3|TRUE
ZW|||zettawatt|N m/s|watt|1.0000000000000000E+21|power|M L^2 / t^3|TRUE
EW|||exawatt|N m/s|watt|1.0000000000000000E+18|power|M L^2 / t^3|TRUE
PW|||petawatt|N m/s|watt|1.0000000000000000E+15|power|M L^2 / t^3|TRUE
TW|||terawatt|N m/s|watt|1.0000000000000000E+12|power|M L^2 / t^3|TRUE
GW|||gigawatt|N m/s|watt|1.0000000000000000E+09|power|M L^2 / t^3|TRUE
MW|||megawatt|N m/s|watt|1.0000000000000000E+06|power|M L^2 / t^3|TRUE
kW|||kilowatt|N m/s|watt|1.0000000000000000E+03|power|M L^2 / t^3|TRUE
hW|||hectowatt|N m/s|watt|1.0000000000000000E+02|power|M L^2 / t^3|TRUE
daW|||decawatt|N m/s|watt|1.0000000000000000E+01|power|M L^2 / t^3|TRUE
W|||watt|N m/s|watt|1.0000000000000000E+00|power|M L^2 / t^3|TRUE
dW|||deciwatt|N m/s|watt|1.0000000000000000E-01|power|M L^2 / t^3|TRUE
cW|||centiwatt|N m/s|watt|1.0000000000000000E-02|power|M L^2 / t^3|TRUE
mW|||milliwatt|N m/s|watt|1.0000000000000000E-03|power|M L^2 / t^3|TRUE
uW|||microwatt|N m/s|watt|1.0000000000000000E-06|power|M L^2 / t^3|TRUE
nW|||nanowatt|N m/s|watt|1.0000000000000000E-09|power|M L^2 / t^3|TRUE
pW|||picowatt|N m/s|watt|1.0000000000000000E-12|power|M L^2 / t^3|TRUE
fW|||femtowatt|N m/s|watt|1.0000000000000000E-15|power|M L^2 / t^3|TRUE
aW|||attowatt|N m/s|watt|1.0000000000000000E-18|power|M L^2 / t^3|TRUE
zW|||zeptowatt|N m/s|watt|1.0000000000000000E-21|power|M L^2 / t^3|TRUE
yW|||yoctowatt|N m/s|watt|1.0000000000000000E-24|power|M L^2 / t^3|TRUE
abfarad |||abfarad|F|farad|1.0000000000000000E+09|capacitance|L|FALSE
statfarad|||ESU_of_capacitance_(statfarad)|F|farad|1.1126500000000000E-12|capacitance|L|FALSE
statfarad |||statfarad|F|farad|1.1126500000000000E-12|capacitance|L|FALSE
abcoulomb |||abcoulomb|C|coulomb|1.0000000000000000E+01|charge|M^(1/2) L^(3/2) / t|FALSE
amp hr|||ampere_hour|C|coulomb|3.6000000000000000E+03|charge|M^(1/2) L^(3/2) / t|FALSE
faraday|||faraday_(based_on_carbon_12)|C|coulomb|9.6485340000000000E+04|charge|M^(1/2) L^(3/2) / t|FALSE
Fr|||franklin|C|coulomb|3.3356410000000000E-10|charge|M^(1/2) L^(3/2) / t|FALSE
statcoulomb |||statcoulomb|C|coulomb|3.3356410000000000E-10|charge|M^(1/2) L^(3/2) / t|FALSE
abmho |||abmho|S|siemens|1.0000000000000000E+09|conductance|L / t|FALSE
mho|||mho|S|siemens|1.0000000000000000E+00|conductance|L / t|FALSE
statmho |||statmho|S|siemens|1.1126500000000000E-12|conductance|L / t|FALSE
abamp|||abampere|A|ampere|1.0000000000000000E+01|current|M^(1/2) L^(3/2) / t^2|FALSE
biot|||biot|A|ampere|1.0000000000000000E+01|current|M^(1/2) L^(3/2) / t^2|FALSE
statampere|||ESU_of_current_(statampere)|A|ampere|3.3356410000000000E-10|current|M^(1/2) L^(3/2) / t^2|FALSE
Gi|||gilbert|A|ampere|7.9577470000000000E-01|current|M^(1/2) L^(3/2) / t^2|FALSE
statampere |statamp||statampere|A|ampere|3.3356410000000000E-10|current|M^(1/2) L^(3/2) / t^2|FALSE
abhenry |||abhenry|H|henry|1.0000000000000000E-09|inductance|t^2/L|FALSE
stathenry|||ESU_of_inductance_(stathenry)|H|henry|8.9875520000000000E+11|inductance|t^2 / L|FALSE
stathenry |||stathenry|H|henry|8.9875520000000000E+11|inductance|t^2 / L|FALSE
Oe|||oersted|A/m|ampere per meter|7.9577470000000000E+01|magnetic field strength|M^(1/2) L^(1/2) / t^2|FALSE
Mx|||maxwell|Wb|weber|1.0000000000000000E-08|magnetic flux|M^(1/2) L^(1/2)|FALSE
unit_pole|||unit_pole|Wb|weber|1.2566370000000000E-07|magnetic flux|M^(1/2) L^(1/2)|FALSE
?|||gamma|T|tesla|1.0000000000000000E-09|magnetic flux density|M^(1/2) / L^(3/2)|FALSE
Gs|G||gauss|T|tesla|1.0000000000000000E-04|magnetic flux density|M^(1/2) / L^(3/2)|FALSE
abvolt |||abvolt|V|volt|1.0000000000000000E-08|potential|M^(1/2) L^(1/2) / t|FALSE
statvolt|||ESU_of_electric_potential_(statvolt)|V|volt|2.9979250000000000E+02|potential|M^(1/2) L^(1/2) / t|FALSE
statvolt |||statvolt_|V|volt|2.9979250000000000E+02|potential|M^(1/2) L^(1/2) / t|FALSE
abohm |||abohm_|ê|ohm|1.0000000000000000E-09|resistance|t / L|FALSE
statohm|||ESU_of_resistance_(statohm)|ê|ohm|8.9875520000000000E+11|resistance|t / L|FALSE
statohm |||statohm|ê|ohm|8.9875520000000000E+11|resistance|t / L|FALSE
clo|||clo_|m2 K/W|square meter kelvin per watt|1.5500000000000000E+01|thermal insulance|t^3 T / M|FALSE
cd/in2|||candela_per_square_inch|cd/m2|candela per square meter|1.5500030000000000E+09|luminance|J / L^2|FALSE
fc|||foot_candle|lx|lux|1.0763910000000000E+01|luminance||FALSE
fl|||foot_lambert|cd/m2|candela per square meter|3.4262590000000000E+06|luminance|J / L^2|FALSE
Lb|||lambert|cd/m2|candela per square meter|3.1830990000000000E+09|luminance|J / L^2|FALSE
lm/ft2|||lumen_per_square_foot|lx|lux|1.0763910000000000E+01|luminance|J / L^2|FALSE
ph|||phot|lx|lux|1.0000000000000000E+04|luminance|J / L^2|FALSE
cP|||centipoise|Pa s|pascal second|1.0000000000000000E-03|dynamic viscosity|M / L t|FALSE
P|||poise|Pa s|pascal second|1.0000000000000000E-01|dynamic viscosity|M / L t|FALSE
rhe|||rhe_|1/Pa s|reciprocal pascal second)|1.0000000000000000E+01|reciprocal dynamic viscosity|L t / M|FALSE
YSt|||yottastoke|m2/s|meter squared per second|1.0000000000000000E+20|kinematic viscosity|L^2 / t|TRUE
ZSt|||zettastoke|m2/s|meter squared per second|1.0000000000000000E+17|kinematic viscosity|L^2 / t|TRUE
ESt|||exastoke|m2/s|meter squared per second|1.0000000000000000E+14|kinematic viscosity|L^2 / t|TRUE
PSt|||petastoke|m2/s|meter squared per second|1.0000000000000000E+11|kinematic viscosity|L^2 / t|TRUE
TSt|||terastoke|m2/s|meter squared per second|1.0000000000000000E+08|kinematic viscosity|L^2 / t|TRUE
GSt|||gigastoke|m2/s|meter squared per second|1.0000000000000000E+05|kinematic viscosity|L^2 / t|TRUE
MSt|||megastoke|m2/s|meter squared per second|1.0000000000000000E+02|kinematic viscosity|L^2 / t|TRUE
kSt|||kilostoke|m2/s|meter squared per second|1.0000000000000000E-01|kinematic viscosity|L^2 / t|TRUE
hSt|||hectostoke|m2/s|meter squared per second|1.0000000000000000E-02|kinematic viscosity|L^2 / t|TRUE
daSt|||decastoke|m2/s|meter squared per second|1.0000000000000000E-03|kinematic viscosity|L^2 / t|TRUE
St|||stoke|m2/s|meter squared per second|1.0000000000000000E-04|kinematic viscosity|L^2 / t|TRUE
dSt|||decistoke|m2/s|meter squared per second|1.0000000000000000E-05|kinematic viscosity|L^2 / t|TRUE
cSt|||centistoke|m2/s|meter squared per second|1.0000000000000000E-06|kinematic viscosity|L^2 / t|TRUE
mSt|||millistoke|m2/s|meter squared per second|1.0000000000000000E-07|kinematic viscosity|L^2 / t|TRUE
uSt|||microstoke|m2/s|meter squared per second|1.0000000000000000E-10|kinematic viscosity|L^2 / t|TRUE
nSt|||nanostoke|m2/s|meter squared per second|1.0000000000000000E-13|kinematic viscosity|L^2 / t|TRUE
pSt|||picostoke|m2/s|meter squared per second|1.0000000000000000E-16|kinematic viscosity|L^2 / t|TRUE
fSt|||femtostoke|m2/s|meter squared per second|1.0000000000000000E-19|kinematic viscosity|L^2 / t|TRUE
aSt|||attostoke|m2/s|meter squared per second|1.0000000000000000E-22|kinematic viscosity|L^2 / t|TRUE
zSt|||zeptostoke|m2/s|meter squared per second|1.0000000000000000E-25|kinematic viscosity|L^2 / t|TRUE
ySt|||yoctostoke|m2/s|meter squared per second|1.0000000000000000E-28|kinematic viscosity|L^2 / t|TRUE
GPM|gpm||gallon_(US)_per_minute|m3/s|cubic meter per second|6.3090196400000000E-05|volume rate|L^3 / t|TRUE
CFM|cfm||cubic_feet_per_minute|m3/s|cubic meter per second|4.7194744320000000E-04|volume rate|L^3 / t|TRUE
LPM|lpm||liters_per_minute|m3/s|cubic meter per second|1.6666666666666700E-05|volume rate|L^3 / t|TRUE";

        public const string Threads =
// Fraction|N|Series|Class|FractionCallout|DecimalCallout|Allowance|MajorMax|MajorBasic|MajorMin|MajorMinE|PitchMax|PitchMin|MinorMax|MinorMin|Tol
@"Fraction|N|Series|Class|FractionCallout|DecimalCallout|Allowance|MajorMax|MajorBasic|MajorMin|MajorMinE|PitchMax|PitchMin|MinorMax|MinorMin|Tol
0|80|UNF|2A|0-80 UNF 2A|.060-80 UNF 2A|0.0005|0.0595|0.06|0.0563|-|0.0514|0.0496|0.0446|-|
0|80|UNF|2B|0-80 UNF 2B|.060-80 UNF 2B|-|-|0.06|0.06|-|0.0542|0.0519|0.0514|0.0465|
0|80|UNF|3A|0-80 UNF 3A|.060-80 UNF 3A|0|0.06|0.06|0.0568|-|0.0519|0.0506|0.0451|-|
0|80|UNF|3B|0-80 UNF 3B|.060-80 UNF 3B|-|-|0.06|0.06|-|0.0536|0.0519|0.0514|0.0465|
1|64|UNC|2A|1-64 UNC 2A|.073-64 UNC 2A|0.0006|0.0724|0.073|0.0686|-|0.0623|0.0603|0.0538|-|
1|64|UNC|2B|1-64 UNC 2B|.073-64 UNC 2B|-|-|0.073|0.073|-|0.0655|0.0629|0.0623|0.0561|
1|64|UNC|3A|1-64 UNC 3A|.073-64 UNC 3A|0|0.073|0.073|0.0692|-|0.0629|0.0614|0.0544|-|
1|64|UNC|3B|1-64 UNC 3B|.073-64 UNC 3B|-|-|0.073|0.073|-|0.0648|0.0629|0.0623|0.0561|
1|72|UNF|2A|1-72 UNF 2A|.073-72 UNF 2A|0.0006|0.0724|0.073|0.0689|-|0.0634|0.0615|0.0559|-|
1|72|UNF|2B|1-72 UNF 2B|.073-72 UNF 2B|-|-|0.073|0.073|-|0.0665|0.064|0.0635|0.058|
1|72|UNF|3A|1-72 UNF 3A|.073-72 UNF 3A|0|0.073|0.073|0.0695|-|0.064|0.0626|0.0565|-|
1|72|UNF|3B|1-72 UNF 3B|.073-72 UNF 3B|-|-|0.073|0.073|-|0.0659|0.064|0.0635|0.058|
2|56|UNC|2A|2-56 UNC 2A|.086-56 UNC 2A|0.0006|0.0854|0.086|0.0813|-|0.0738|0.0717|0.0642|-|
2|56|UNC|2B|2-56 UNC 2B|.086-56 UNC 2B|-|-|0.086|0.086|-|0.0772|0.0744|0.0737|0.0667|
2|56|UNC|3A|2-56 UNC 3A|.086-56 UNC 3A|0|0.086|0.086|0.0819|-|0.0744|0.0728|0.0648|-|
2|56|UNC|3B|2-56 UNC 3B|.086-56 UNC 3B|-|-|0.086|0.086|-|0.0765|0.0744|0.0737|0.0667|
2|64|UNF|2A|2-64 UNF 2A|.086-64 UNF 2A|0.0006|0.0854|0.086|0.0816|-|0.0753|0.0733|0.0668|-|
2|64|UNF|2B|2-64 UNF 2B|.086-64 UNF 2B|-|-|0.086|0.086|-|0.0786|0.0759|0.0753|0.0691|
2|64|UNF|3A|2-64 UNF 3A|.086-64 UNF 3A|0|0.086|0.086|0.0822|-|0.0759|0.0744|0.0674|-|
2|64|UNF|3B|2-64 UNF 3B|.086-64 UNF 3B|-|-|0.086|0.086|-|0.0779|0.0759|0.0753|0.0691|
3|48|UNC|2A|3-48 UNC 2A|.099-48 UNC 2A|0.0007|0.0983|0.099|0.0938|-|0.0848|0.0825|0.0734|-|
3|48|UNC|2B|3-48 UNC 2B|.099-48 UNC 2B|-|-|0.099|0.099|-|0.0885|0.0855|0.0845|0.0764|
3|48|UNC|3A|3-48 UNC 3A|.099-48 UNC 3A|0|0.099|0.099|0.0945|-|0.0855|0.0838|0.0741|-|
3|48|UNC|3B|3-48 UNC 3B|.099-48 UNC 3B|-|-|0.099|0.099|-|0.0877|0.0855|0.0845|0.0764|
3|56|UNF|2A|3-56 UNF 2A|.099-56 UNF 2A|0.0007|0.0983|0.099|0.0942|-|0.0867|0.0845|0.0771|-|
3|56|UNF|2B|3-56 UNF 2B|.099-56 UNF 2B|-|-|0.099|0.099|-|0.0902|0.0874|0.0865|0.0797|
3|56|UNF|3A|3-56 UNF 3A|.099-56 UNF 3A|0|0.099|0.099|0.0949|-|0.0874|0.0858|0.0778|-|
3|56|UNF|3B|3-56 UNF 3B|.099-56 UNF 3B|-|-|0.099|0.099|-|0.0895|0.0874|0.0865|0.0797|
4|40|UNC|2A|4-40 UNC 2A|.112-40 UNC 2A|0.0008|0.1112|0.112|0.1061|-|0.095|0.0925|0.0814|-|
4|40|UNC|2B|4-40 UNC 2B|.112-40 UNC 2B|-|-|0.112|0.112|-|0.0991|0.0958|0.0939|0.0849|
4|40|UNC|3A|4-40 UNC 3A|.112-40 UNC 3A|0|0.112|0.112|0.1069|-|0.0958|0.0939|0.0822|-|
4|40|UNC|3B|4-40 UNC 3B|.112-40 UNC 3B|-|-|0.112|0.112|-|0.0982|0.0958|0.0939|0.0849|
4|48|UNF|2A|4-48 UNF 2A|.112-48 UNF 2A|0.0007|0.1113|0.112|0.1068|-|0.0978|0.0954|0.0864|-|
4|48|UNF|2B|4-48 UNF 2B|.112-48 UNF 2B|-|-|0.112|0.112|-|0.1016|0.0985|0.0968|0.0894|
4|48|UNF|3A|4-48 UNF 3A|.112-48 UNF 3A|0|0.112|0.112|0.1075|-|0.0985|0.0967|0.0871|-|
4|48|UNF|3B|4-48 UNF 3B|.112-48 UNF 3B|-|-|0.112|0.112|-|0.1008|0.0985|0.0968|0.0894|
5|40|UNC|2A|5-40 UNC 2A|.125-40 UNC 2A|0.0008|0.1242|0.125|0.1191|-|0.108|0.1054|0.0944|-|
5|40|UNC|2B|5-40 UNC 2B|.125-40 UNC 2B|-|-|0.125|0.125|-|0.1121|0.1088|0.1062|0.0979|
5|40|UNC|3A|5-40 UNC 3A|.125-40 UNC 3A|0|0.125|0.125|0.1199|-|0.1088|0.1069|0.0952|-|
5|40|UNC|3B|5-40 UNC 3B|.125-40 UNC 3B|-|-|0.125|0.125|-|0.1113|0.1088|0.1062|0.0979|
5|44|UNF|2A|5-44 UNF 2A|.125-44 UNF 2A|0.0007|0.1243|0.125|0.1195|-|0.1095|0.107|0.0972|-|
5|44|UNF|2B|5-44 UNF 2B|.125-44 UNF 2B|-|-|0.125|0.125|-|0.1134|0.1102|0.1079|0.1004|
5|44|UNF|3A|5-44 UNF 3A|.125-44 UNF 3A|0|0.125|0.125|0.1202|-|0.1102|0.1083|0.0979|-|
5|44|UNF|3B|5-44 UNF 3B|.125-44 UNF 3B|-|-|0.125|0.125|-|0.1126|0.1102|0.1079|0.1004|
6|32|UNC|2A|6-32 UNC 2A|.138-32 UNC 2A|0.0008|0.1372|0.138|0.1312|-|0.1169|0.1141|0.1|-|
6|32|UNC|2B|6-32 UNC 2B|.138-32 UNC 2B|-|-|0.138|0.138|-|0.1214|0.1177|0.114|0.104|
6|32|UNC|3A|6-32 UNC 3A|.138-32 UNC 3A|0|0.138|0.138|0.132|-|0.1177|0.1156|0.1008|-|
6|32|UNC|3B|6-32 UNC 3B|.138-32 UNC 3B|-|-|0.138|0.138|-|0.1204|0.1177|0.114|0.104|
6|40|UNF|2A|6-40 UNF 2A|.138-40 UNF 2A|0.0008|0.1372|0.138|0.1321|-|0.121|0.1184|0.1074|-|
6|40|UNF|2B|6-40 UNF 2B|.138-40 UNF 2B|-|-|0.138|0.138|-|0.1252|0.1218|0.119|0.111|
6|40|UNF|3A|6-40 UNF 3A|.138-40 UNF 3A|0|0.138|0.138|0.1329|-|0.1218|0.1198|0.1082|-|
6|40|UNF|3B|6-40 UNF 3B|.138-40 UNF 3B|-|-|0.138|0.138|-|0.1243|0.1218|0.1186|0.111|
8|32|UNC|2A|8-32 UNC 2A|.164-32 UNC 2A|0.0009|0.1631|0.164|0.1571|-|0.1428|0.1399|0.1259|-|
8|32|UNC|2B|8-32 UNC 2B|.164-32 UNC 2B|-|-|0.164|0.164|-|0.1475|0.1437|0.139|0.13|
8|32|UNC|3A|8-32 UNC 3A|.164-32 UNC 3A|0|0.164|0.164|0.158|-|0.1437|0.1415|0.1268|-|
8|32|UNC|3B|8-32 UNC 3B|.164-32 UNC 3B|-|-|0.164|0.164|-|0.1465|0.1437|0.1389|0.13|
8|36|UNF|2A|8-36 UNF 2A|.164-36 UNF 2A|0.0008|0.1632|0.164|0.1577|-|0.1452|0.1424|0.1301|-|
8|36|UNF|2B|8-36 UNF 2B|.164-36 UNF 2B|-|-|0.164|0.164|-|0.1496|0.146|0.142|0.134|
8|36|UNF|3A|8-36 UNF 3A|.164-36 UNF 3A|0|0.164|0.164|0.1585|-|0.146|0.1439|0.1309|-|
8|36|UNF|3B|8-36 UNF 3B|.164-36 UNF 3B|-|-|0.164|0.164|-|0.1487|0.146|0.1416|0.134|
10|24|UNC|2A|10-24 UNC 2A|.190-24 UNC 2A|0.001|0.189|0.19|0.1818|-|0.1619|0.1586|0.1394|-|
10|24|UNC|2B|10-24 UNC 2B|.190-24 UNC 2B|-|-|0.19|0.19|-|0.1672|0.1629|0.156|0.145|
10|24|UNC|3A|10-24 UNC 3A|.190-24 UNC 3A|0|0.19|0.19|0.1828|-|0.1629|0.1604|0.1404|-|
10|24|UNC|3B|10-24 UNC 3B|.190-24 UNC 3B|-|-|0.19|0.19|-|0.1661|0.1629|0.1555|0.145|
10|28|UNS|2A|10-28 UNS 2A|.190-28 UNS 2A|0.001|0.189|0.19|0.1825|-|0.1658|0.1625|0.1464|-|
10|28|UNS|2B|10-28 UNS 2B|.190-28 UNS 2B|-|-|0.19|0.19|-|0.1711|0.1668|0.16|0.151|
10|32|UNF|2A|10-32 UNF 2A|.190-32 UNF 2A|0.0009|0.1891|0.19|0.1831|-|0.1688|0.1658|0.1519|-|
10|32|UNF|2B|10-32 UNF 2B|.190-32 UNF 2B|-|-|0.19|0.19|-|0.1736|0.1697|0.164|0.156|
10|32|UNF|3A|10-32 UNF 3A|.190-32 UNF 3A|0|0.19|0.19|0.184|-|0.1697|0.1674|0.1528|-|
10|32|UNF|3B|10-32 UNF 3B|.190-32 UNF 3B|-|-|0.19|0.19|-|0.1726|0.1697|0.1641|0.156|
10|36|UNS|2A|10-36 UNS 2A|.190-36 UNS 2A|0.0009|0.1891|0.19|0.1836|-|0.1711|0.1681|0.156|-|
10|36|UNS|2B|10-36 UNS 2B|.190-36 UNS 2B|-|-|0.19|0.19|-|0.1759|0.172|0.166|0.16|
10|40|UNS|2A|10-40 UNS 2A|.190-40 UNS 2A|0.0009|0.1891|0.19|0.184|-|0.1729|0.17|0.1592|-|
10|40|UNS|2B|10-40 UNS 2B|.190-40 UNS 2B|-|-|0.19|0.19|-|0.1775|0.1738|0.169|0.163|
10|48|UNS|2A|10-48 UNS 2A|.190-48 UNS 2A|0.0008|0.1892|0.19|0.1847|-|0.1757|0.1731|0.1644|-|
10|48|UNS|2B|10-48 UNS 2B|.190-48 UNS 2B|-|-|0.19|0.19|-|0.1799|0.1765|0.172|0.167|
10|56|UNS|2A|10-56 UNS 2A|.190-56 UNS 2A|0.0007|0.1893|0.19|0.1852|-|0.1777|0.1752|0.1681|-|
10|56|UNS|2B|10-56 UNS 2B|.190-56 UNS 2B|-|-|0.19|0.19|-|0.1816|0.1784|0.175|0.171|
12|24|UNC|2A|12-24 UNC 2A|.216-24 UNC 2A|0.001|0.215|0.216|0.2078|-|0.1879|0.1845|0.1654|-|
12|24|UNC|2B|12-24 UNC 2B|.216-24 UNC 2B|-|-|0.216|0.216|-|0.1933|0.1889|0.181|0.171|
12|24|UNC|3A|12-24 UNC 3A|.216-24 UNC 3A|0|0.216|0.216|0.2088|-|0.1889|0.1863|0.1664|-|
12|24|UNC|3B|12-24 UNC 3B|.216-24 UNC 3B|-|-|0.216|0.216|-|0.1922|0.1889|0.1807|0.171|
12|28|UNF|2A|12-28 UNF 2A|.216-28 UNF 2A|0.001|0.215|0.216|0.2085|-|0.1918|0.1886|0.1724|-|
12|28|UNF|2B|12-28 UNF 2B|.216-28 UNF 2B|-|-|0.216|0.216|-|0.197|0.1928|0.186|0.177|
12|28|UNF|3A|12-28 UNF 3A|.216-28 UNF 3A|0|0.216|0.216|0.2095|-|0.1928|0.1904|0.1734|-|
12|28|UNF|3B|12-28 UNF 3B|.216-28 UNF 3B|-|-|0.216|0.216|-|0.1959|0.1928|0.1857|0.177|
12|32|UNEF|2A|12-32 UNEF 2A|.216-32 UNEF 2A|0.0009|0.2151|0.216|0.2091|-|0.1948|0.1917|0.1779|-|
12|32|UNEF|2B|12-32 UNEF 2B|.216-32 UNEF 2B|-|-|0.216|0.216|-|0.1998|0.1957|0.19|0.182|
12|32|UNEF|3A|12-32 UNEF 3A|.216-32 UNEF 3A|0|0.216|0.216|0.21|-|0.1957|0.1933|0.1788|-|
12|32|UNEF|3B|12-32 UNEF 3B|.216-32 UNEF 3B|-|-|0.216|0.216|-|0.1988|0.1957|0.1895|0.182|
12|36|UNS|2A|12-36 UNS 2A|.216-36 UNS 2A|0.0009|0.2151|0.216|0.2096|-|0.1971|0.1941|0.1821|-|
12|36|UNS|2B|12-36 UNS 2B|.216-36 UNS 2B|-|-|0.216|0.216|-|0.2019|0.198|0.192|0.186|
12|40|UNS|2A|12-40 UNS 2A|.216-40 UNS 2A|0.0009|0.2151|0.216|0.21|-|0.1989|0.196|0.1835|-|
12|40|UNS|2B|12-40 UNS 2B|.216-40 UNS 2B|-|-|0.216|0.216|-|0.2035|0.1998|0.195|0.189|
12|48|UNS|2A|12-48 UNS 2A|.216-48 UNS 2A|0.0008|0.2152|0.216|0.2107|-|0.2017|0.1991|0.1904|-|
12|48|UNS|2B|12-48 UNS 2B|.216-48 UNS 2B|-|-|0.216|0.216|-|0.2059|0.2025|0.198|0.193|
12|56|UNS|2A|12-56 UNS 2A|.216-56 UNS 2A|0.0007|0.2153|0.216|0.2112|-|0.2037|0.2012|0.1941|-|
12|56|UNS|2B|12-56 UNS 2B|.216-56 UNS 2B|-|-|0.216|0.216|-|0.2076|0.2044|0.201|0.197|
1/4|20|UNC|1A|1/4-20 UNC 1A|.250-20 UNC 1A|0.0011|0.2489|0.25|0.2367|-|0.2164|0.2108|0.1894|-|
1/4|20|UNC|1B|1/4-20 UNC 1B|.250-20 UNC 1B|-|-|0.25|0.25|-|0.2248|0.2175|0.207|0.196|
1/4|20|UNC|2A|1/4-20 UNC 2A|.250-20 UNC 2A|0.0011|0.2489|0.25|0.2408|0.2367|0.2164|0.2127|0.1894|-|
1/4|20|UNC|2B|1/4-20 UNC 2B|.250-20 UNC 2B|-|-|0.25|0.25|-|0.2224|0.2175|0.207|0.196|
1/4|20|UNC|3A|1/4-20 UNC 3A|.250-20 UNC 3A|0|0.25|0.25|0.2419|-|0.2175|0.2147|0.1905|-|
1/4|20|UNC|3B|1/4-20 UNC 3B|.250-20 UNC 3B|-|-|0.25|0.25|-|0.2211|0.2175|0.2067|0.196|
1/4|24|UNS|2A|1/4-24 UNS 2A|.250-24 UNS 2A|0.0011|0.2489|0.25|0.2417|-|0.2218|0.2181|0.1993|-|
1/4|24|UNS|2B|1/4-24 UNS 2B|.250-24 UNS 2B|-|-|0.25|0.25|-|0.2277|0.2229|0.215|0.205|
1/4|27|UNS|2A|1/4-27 UNS 2A|.250-27 UNS 2A|0.001|0.249|0.25|0.2423|-|0.2249|0.2214|0.2049|-|
1/4|27|UNS|2B|1/4-27 UNS 2B|.250-27 UNS 2B|-|-|0.25|0.25|-|0.2304|0.2259|0.219|0.21|
1/4|28|UNF|1A|1/4-28 UNF 1A|.250-28 UNF 1A|0.001|0.249|0.25|0.2392|-|0.2258|0.2208|0.2064|-|
1/4|28|UNF|1B|1/4-28 UNF 1B|.250-28 UNF 1B|-|-|0.25|0.25|-|0.2333|0.2268|0.22|0.211|
1/4|28|UNF|2A|1/4-28 UNF 2A|.250-28 UNF 2A|0.001|0.249|0.25|0.2425|-|0.2258|0.2225|0.2064|-|
1/4|28|UNF|2B|1/4-28 UNF 2B|.250-28 UNF 2B|-|-|0.25|0.25|-|0.2311|0.2268|0.22|0.211|
1/4|28|UNF|3A|1/4-28 UNF 3A|.250-28 UNF 3A|0|0.25|0.25|0.2435|-|0.2268|0.2243|0.2074|-|
1/4|28|UNF|3B|1/4-28 UNF 3B|.250-28 UNF 3B|-|-|0.25|0.25|-|0.23|0.2268|0.219|0.211|
1/4|32|UNEF|2A|1/4-32 UNEF 2A|.250-32 UNEF 2A|0.001|0.249|0.25|0.243|-|0.2287|0.2255|0.2118|-|
1/4|32|UNEF|2B|1/4-32 UNEF 2B|.250-32 UNEF 2B|-|-|0.25|0.25|-|0.2339|0.2297|0.224|0.216|
1/4|32|UNEF|3A|1/4-32 UNEF 3A|.250-32 UNEF 3A|0|0.25|0.25|0.244|-|0.2297|0.2273|0.2128|-|
1/4|32|UNEF|3B|1/4-32 UNEF 3B|.250-32 UNEF 3B|-|-|0.25|0.25|-|0.2328|0.2297|0.2229|0.216|
1/4|36|UNS|2A|1/4-36 UNS 2A|.250-36 UNS 2A|0.0009|0.2491|0.25|0.2436|-|0.2311|0.228|0.2161|-|
1/4|36|UNS|2B|1/4-36 UNS 2B|.250-36 UNS 2B|-|-|0.25|0.25|-|0.236|0.232|0.226|0.22|
1/4|40|UNS|2A|1/4-40 UNS 2A|.250-40 UNS 2A|0.0009|0.2491|0.25|0.244|-|0.2329|0.23|0.2193|-|
1/4|40|UNS|2B|1/4-40 UNS 2B|.250-40 UNS 2B|-|-|0.25|0.25|-|0.2376|0.2338|0.229|0.223|
1/4|48|UNS|2A|1/4-48 UNS 2A|.250-48 UNS 2A|0.0008|0.2492|0.25|0.2447|-|0.2357|0.233|0.2243|-|
1/4|48|UNS|2B|1/4-48 UNS 2B|.250-48 UNS 2B|-|-|0.25|0.25|-|0.2401|0.2365|0.232|0.227|
1/4|56|UNS|2A|1/4-56 UNS 2A|.250-56 UNS 2A|0.0008|0.2492|0.25|0.2451|-|0.2376|0.235|0.228|-|
1/4|56|UNS|2B|1/4-56 UNS 2B|.250-56 UNS 2B|-|-|0.25|0.25|-|0.2417|0.2384|0.235|0.231|
5/16|18|UNC|1A|5/16-18 UNC 1A|.313-18 UNC 1A|0.0012|0.3113|0.3125|0.2982|-|0.2752|0.2691|0.2452|-|
5/16|18|UNC|1B|5/16-18 UNC 1B|.313-18 UNC 1B|-|-|0.3125|0.3125|-|0.2843|0.2764|0.265|0.252|
5/16|18|UNC|2A|5/16-18 UNC 2A|.313-18 UNC 2A|0.0012|0.3113|0.3125|0.3026|0.2982|0.2752|0.2712|0.2452|-|
5/16|18|UNC|2B|5/16-18 UNC 2B|.313-18 UNC 2B|-|-|0.3125|0.3125|-|0.2817|0.2764|0.265|0.252|
5/16|18|UNC|3A|5/16-18 UNC 3A|.313-18 UNC 3A|0|0.3125|0.3125|0.3038|-|0.2764|0.2734|0.2464|-|
5/16|18|UNC|3B|5/16-18 UNC 3B|.313-18 UNC 3B|-|-|0.3125|0.3125|-|0.2803|0.2764|0.263|0.252|
5/16|20|UN|2A|5/16-20 UN 2A|.313-20 UN 2A|0.0012|0.3113|0.3125|0.3032|-|0.2788|0.2748|0.2518|-|
5/16|20|UN|2B|5/16-20 UN 2B|.313-20 UN 2B|-|-|0.3125|0.3125|-|0.2852|0.28|0.27|0.258|
5/16|20|UN|3A|5/16-20 UN 3A|.313-20 UN 3A|0|0.3125|0.3125|0.3044|-|0.28|0.277|0.253|-|
5/16|20|UN|3B|5/16-20 UN 3B|.313-20 UN 3B|-|-|0.3125|0.3125|-|0.2839|0.28|0.268|0.258|
5/16|24|UNF|1A|5/16-24 UNF 1A|.313-24 UNF 1A|0.0011|0.3114|0.3125|0.3006|-|0.2843|0.2788|0.2618|-|
5/16|24|UNF|1B|5/16-24 UNF 1B|.313-24 UNF 1B|-|-|0.3125|0.3125|-|0.2925|0.2854|0.277|0.267|
5/16|24|UNF|2A|5/16-24 UNF 2A|.313-24 UNF 2A|0.0011|0.3114|0.3125|0.3042|-|0.2843|0.2806|0.2618|-|
5/16|24|UNF|2B|5/16-24 UNF 2B|.313-24 UNF 2B|-|-|0.3125|0.3125|-|0.2902|0.2854|0.277|0.267|
5/16|24|UNF|3A|5/16-24 UNF 3A|.313-24 UNF 3A|0|0.3125|0.3125|0.3053|-|0.2854|0.2827|0.2629|-|
5/16|24|UNF|3B|5/16-24 UNF 3B|.313-24 UNF 3B|-|-|0.3125|0.3125|-|0.289|0.2854|0.2754|0.267|
5/16|27|UNS|2A|5/16-27 UNS 2A|.313-27 UNS 2A|0.001|0.3115|0.3125|0.3048|-|0.2874|0.2839|0.2674|-|
5/16|27|UNS|2B|5/16-27 UNS 2B|.313-27 UNS 2B|-|-|0.3125|0.3125|-|0.2929|0.2884|0.281|0.272|
5/16|28|UN|2A|5/16-28 UN 2A|.313-28 UN 2A|0.001|0.3115|0.3125|0.305|-|0.2883|0.2849|0.2689|-|
5/16|28|UN|2B|5/16-28 UN 2B|.313-28 UN 2B|-|-|0.3125|0.3125|-|0.2937|0.2893|0.282|0.274|
5/16|28|UN|3A|5/16-28 UN 3A|.313-28 UN 3A|0|0.3125|0.3125|0.306|-|0.2893|0.2867|0.2699|-|
5/16|28|UN|3B|5/16-28 UN 3B|.313-28 UN 3B|-|-|0.3125|0.3125|-|0.2926|0.2893|0.2807|0.274|
5/16|32|UNEF|2A|5/16-32 UNEF 2A|.313-32 UNEF 2A|0.001|0.3115|0.3125|0.3055|-|0.2912|0.288|0.2743|-|
5/16|32|UNEF|2B|5/16-32 UNEF 2B|.313-32 UNEF 2B|-|-|0.3125|0.3125|-|0.2964|0.2922|0.286|0.279|
5/16|32|UNEF|3A|5/16-32 UNEF 3A|.313-32 UNEF 3A|0|0.3125|0.3125|0.3065|-|0.2922|0.2898|0.2753|-|
5/16|32|UNEF|3B|5/16-32 UNEF 3B|.313-32 UNEF 3B|-|-|0.3125|0.3125|-|0.2953|0.2922|0.2847|0.279|
5/16|36|UNS|2A|5/16-36 UNS 2A|.313-36 UNS 2A|0.0009|0.3116|0.3125|0.3061|-|0.2936|0.2905|0.2785|-|
5/16|36|UNS|2B|5/16-36 UNS 2B|.313-36 UNS 2B|-|-|0.3125|0.3125|-|0.2985|0.2945|0.289|0.282|
5/16|40|UNS|2A|5/16-40 UNS 2A|.313-40 UNS 2A|0.0009|0.3116|0.3125|0.3065|-|0.2954|0.2925|0.2818|-|
5/16|40|UNS|2B|5/16-40 UNS 2B|.313-40 UNS 2B|-|-|0.3125|0.3125|-|0.3001|0.2963|0.291|0.285|
5/16|48|UNS|2A|5/16-48 UNS 2A|.313-48 UNS 2A|0.0008|0.3117|0.3125|0.3072|-|0.2982|0.2955|0.2869|-|
5/16|48|UNS|2B|5/16-48 UNS 2B|.313-48 UNS 2B|-|-|0.3125|0.3125|-|0.3026|0.299|0.295|0.29|
3/8|16|UNC|1A|3/8-16 UNC 1A|.375-16 UNC 1A|0.0013|0.3737|0.375|0.3595|-|0.3331|0.3266|0.2992|-|
3/8|16|UNC|1B|3/8-16 UNC 1B|.375-16 UNC 1B|-|-|0.375|0.375|-|0.3429|0.3344|0.321|0.307|
3/8|16|UNC|2A|3/8-16 UNC 2A|.375-16 UNC 2A|0.0013|0.3737|0.375|0.3643|0.3595|0.3331|0.3287|0.2992|-|
3/8|16|UNC|2B|3/8-16 UNC 2B|.375-16 UNC 2B|-|-|0.375|0.375|-|0.3401|0.3344|0.321|0.307|
3/8|16|UNC|3A|3/8-16 UNC 3A|.375-16 UNC 3A|0|0.375|0.375|0.3656|-|0.3344|0.3311|0.3005|-|
3/8|16|UNC|3B|3/8-16 UNC 3B|.375-16 UNC 3B|-|-|0.375|0.375|-|0.3387|0.3344|0.3182|0.307|
3/8|18|UNS|2A|3/8-18 UNS 2A|.375-18 UNS 2A|0.0013|0.3737|0.375|0.365|-|0.3376|0.3333|0.3076|-|
3/8|18|UNS|2B|3/8-18 UNS 2B|.375-18 UNS 2B|-|-|0.375|0.375|-|0.3445|0.3389|0.328|0.315|
3/8|20|UN|2A|3/8-20 UN 2A|.375-20 UN 2A|0.0012|0.3738|0.375|0.3657|-|0.3413|0.3372|0.3143|-|
3/8|20|UN|2B|3/8-20 UN 2B|.375-20 UN 2B|-|-|0.375|0.375|-|0.3479|0.3425|0.332|0.321|
3/8|20|UN|3A|3/8-20 UN 3A|.375-20 UN 3A|0|0.375|0.375|0.3669|-|0.3425|0.3394|0.3155|-|
3/8|20|UN|3B|3/8-20 UN 3B|.375-20 UN 3B|-|-|0.375|0.375|-|0.3465|0.3425|0.3297|0.321|
3/8|24|UNF|1A|3/8-24 UNF 1A|.375-24 UNF 1A|0.0011|0.3739|0.375|0.3631|-|0.3468|0.3411|0.3243|-|
3/8|24|UNF|1B|3/8-24 UNF 1B|.375-24 UNF 1B|-|-|0.375|0.375|-|0.3553|0.3479|0.34|0.33|
3/8|24|UNF|2A|3/8-24 UNF 2A|.375-24 UNF 2A|0.0011|0.3739|0.375|0.3667|-|0.3468|0.343|0.3243|-|
3/8|24|UNF|2B|3/8-24 UNF 2B|.375-24 UNF 2B|-|-|0.375|0.375|-|0.3528|0.3479|0.34|0.33|
3/8|24|UNF|3A|3/8-24 UNF 3A|.375-24 UNF 3A|0|0.375|0.375|0.3678|-|0.3479|0.345|0.3254|-|
3/8|24|UNF|3B|3/8-24 UNF 3B|.375-24 UNF 3B|-|-|0.375|0.375|-|0.3516|0.3479|0.3372|0.33|
3/8|27|UNS|2A|3/8-27 UNS 2A|.375-27 UNS 2A|0.0011|0.3739|0.375|0.3672|-|0.3498|0.3462|0.3298|-|
3/8|27|UNS|2B|3/8-27 UNS 2B|.375-27 UNS 2B|-|-|0.375|0.375|-|0.3556|0.3509|0.344|0.335|
3/8|28|UN|2A|3/8-28 UN 2A|.375-28 UN 2A|0.0011|0.3739|0.375|0.3674|-|0.3507|0.3471|0.3313|-|
3/8|28|UN|2B|3/8-28 UN 2B|.375-28 UN 2B|-|-|0.375|0.375|-|0.3564|0.3518|0.345|0.336|
3/8|28|UN|3A|3/8-28 UN 3A|.375-28 UN 3A|0|0.375|0.375|0.3685|-|0.3518|0.3491|0.3324|-|
3/8|28|UN|3B|3/8-28 UN 3B|.375-28 UN 3B|-|-|0.375|0.375|-|0.3553|0.3518|0.3426|0.336|
3/8|32|UNEF|2A|3/8-32 UNEF 2A|.375-32 UNEF 2A|0.001|0.374|0.375|0.368|-|0.3537|0.3503|0.3368|-|
3/8|32|UNEF|2B|3/8-32 UNEF 2B|.375-32 UNEF 2B|-|-|0.375|0.375|-|0.3591|0.3547|0.349|0.341|
3/8|32|UNEF|3A|3/8-32 UNEF 3A|.375-32 UNEF 3A|0|0.375|0.375|0.369|-|0.3547|0.3522|0.3378|-|
3/8|32|UNEF|3B|3/8-32 UNEF 3B|.375-32 UNEF 3B|-|-|0.375|0.375|-|0.358|0.3547|0.3469|0.341|
3/8|36|UNS|2A|3/8-36 UNS 2A|.375-36 UNS 2A|0.001|0.374|0.375|0.3685|-|0.356|0.3528|0.3409|-|
3/8|36|UNS|2B|3/8-36 UNS 2B|.375-36 UNS 2B|-|-|0.375|0.375|-|0.3612|0.357|0.352|0.345|
3/8|40|UNS|2A|3/8-40 UNS 2A|.375-40 UNS 2A|0.0009|0.3741|0.375|0.369|-|0.3579|0.3548|0.3443|-|
3/8|40|UNS|2B|3/8-40 UNS 2B|.375-40 UNS 2B|-|-|0.375|0.375|-|0.3628|0.3588|0.354|0.348|
0.390|27|UNS|2A|0.390-27 UNS 2A|.390-27 UNS 2A|0.0011|0.3889|0.39|0.3822|-|0.3648|0.3612|0.3448|-|
0.390|27|UNS|2B|0.390-27 UNS 2B|.390-27 UNS 2B|-|-|0.39|0.39|-|0.3706|0.3659|0.359|0.35|
7/16|14|UNC|1A|7/16-14 UNC 1A|.438-14 UNC 1A|0.0014|0.4361|0.4375|0.4206|-|0.3897|0.3826|0.3511|-|
7/16|14|UNC|1B|7/16-14 UNC 1B|.438-14 UNC 1B|-|-|0.4375|0.4375|-|0.4003|0.3911|0.376|0.36|
7/16|14|UNC|2A|7/16-14 UNC 2A|.438-14 UNC 2A|0.0014|0.4361|0.4375|0.4258|0.4206|0.3897|0.385|0.3511|-|
7/16|14|UNC|2B|7/16-14 UNC 2B|.438-14 UNC 2B|-|-|0.4375|0.4375|-|0.3972|0.3911|0.376|0.36|
7/16|14|UNC|3A|7/16-14 UNC 3A|.438-14 UNC 3A|0|0.4375|0.4375|0.4272|-|0.3911|0.3876|0.3525|-|
7/16|14|UNC|3B|7/16-14 UNC 3B|.438-14 UNC 3B|-|-|0.4375|0.4375|-|0.3957|0.3911|0.3717|0.36|
7/16|16|UN|2A|7/16-16 UN 2A|.438-16 UN 2A|0.0014|0.4361|0.4375|0.4267|-|0.3955|0.3909|0.3616|-|
7/16|16|UN|2B|7/16-16 UN 2B|.438-16 UN 2B|-|-|0.4375|0.4375|-|0.4028|0.3969|0.384|0.37|
7/16|16|UN|3A|7/16-16 UN 3A|.438-16 UN 3A|0|0.4375|0.4375|0.4281|-|0.3969|0.3935|0.363|-|
7/16|16|UN|3B|7/16-16 UN 3B|.438-16 UN 3B|-|-|0.4375|0.4375|-|0.4014|0.3969|0.38|0.37|
7/16|18|UNS|2A|7/16-18 UNS 2A|.438-18 UNS 2A|0.0013|0.4362|0.4375|0.4275|-|0.4001|0.3958|0.3701|-|
7/16|18|UNS|2B|7/16-18 UNS 2B|.438-18 UNS 2B|-|-|0.4375|0.4375|-|0.407|0.4014|0.39|0.377|
7/16|20|UNF|1A|7/16-20 UNF 1A|.438-20 UNF 1A|0.0013|0.4362|0.4375|0.424|-|0.4037|0.3975|0.3767|-|
7/16|20|UNF|1B|7/16-20 UNF 1B|.438-20 UNF 1B|-|-|0.4375|0.4375|-|0.4131|0.405|0.395|0.383|
7/16|20|UNF|2A|7/16-20 UNF 2A|.438-20 UNF 2A|0.0013|0.4362|0.4375|0.4281|-|0.4037|0.3995|0.3767|-|
7/16|20|UNF|2B|7/16-20 UNF 2B|.438-20 UNF 2B|-|-|0.4375|0.4375|-|0.4104|0.405|0.395|0.383|
7/16|20|UNF|3A|7/16-20 UNF 3A|.438-20 UNF 3A|0|0.4375|0.4375|0.4294|-|0.405|0.4019|0.378|-|
7/16|20|UNF|3B|7/16-20 UNF 3B|.438-20 UNF 3B|-|-|0.4375|0.4375|-|0.4091|0.405|0.3916|0.383|
7/16|24|UNS|2A|7/16-24 UNS 2A|.438-24 UNS 2A|0.0011|0.4364|0.4375|0.4292|-|0.4093|0.4055|0.3868|-|
7/16|24|UNS|2B|7/16-24 UNS 2B|.438-24 UNS 2B|-|-|0.4375|0.4375|-|0.4153|0.4104|0.402|0.392|
7/16|27|UNS|2A|7/16-27 UNS 2A|.438-27 UNS 2A|0.0011|0.4364|0.4375|0.4297|-|0.4123|0.4087|0.3923|-|
7/16|27|UNS|2B|7/16-27 UNS 2B|.438-27 UNS 2B|-|-|0.4375|0.4375|-|0.4181|0.4134|0.406|0.397|
7/16|28|UNEF|2A|7/16-28 UNEF 2A|.438-28 UNEF 2A|0.0011|0.4364|0.4375|0.4299|-|0.4132|0.4096|0.3938|-|
7/16|28|UNEF|2B|7/16-28 UNEF 2B|.438-28 UNEF 2B|-|-|0.4375|0.4375|-|0.4189|0.4143|0.407|0.399|
7/16|28|UNEF|3A|7/16-28 UNEF 3A|.438-28 UNEF 3A|0|0.4375|0.4375|0.431|-|0.4143|0.4116|0.3949|-|
7/16|28|UNEF|3B|7/16-28 UNEF 3B|.438-28 UNEF 3B|-|-|0.4375|0.4375|-|0.4178|0.4143|0.4051|0.399|
7/16|32|UN|2A|7/16-32 UN 2A|.438-32 UN 2A|0.001|0.4365|0.4375|0.4305|-|0.4162|0.4128|0.3993|-|
7/16|32|UN|2B|7/16-32 UN 2B|.438-32 UN 2B|-|-|0.4375|0.4375|-|0.4216|0.4172|0.411|0.404|
7/16|32|UN|3A|7/16-32 UN 3A|.438-32 UN 3A|0|0.4375|0.4375|0.4315|-|0.4172|0.4147|0.4003|-|
7/16|32|UN|3B|7/16-32 UN 3B|.438-32 UN 3B|-|-|0.4375|0.4375|-|0.4205|0.4172|0.4094|0.404|
1/2|12|UNS|2A|1/2-12 UNS 2A|.500-12 UNS 2A|0.0016|0.4984|0.5|0.487|-|0.4443|0.4389|0.3992|-|
1/2|12|UNS|2B|1/2-12 UNS 2B|.500-12 UNS 2B|-|-|0.5|0.5|-|0.4529|0.4459|0.428|0.41|
1/2|12|UNS|3A|1/2-12 UNS 3A|.500-12 UNS 3A|0|0.5|0.5|0.4886|-|0.4459|0.4419|0.4008|-|
1/2|12|UNS|3B|1/2-12 UNS 3B|.500-12 UNS 3B|-|-|0.5|0.5|-|0.4511|0.4459|0.4223|0.41|
1/2|13|UNC|1A|1/2-13 UNC 1A|.500-13 UNC 1A|0.0015|0.4985|0.5|0.4822|-|0.4485|0.4411|0.4069|-|
1/2|13|UNC|1B|1/2-13 UNC 1B|.500-13 UNC 1B|-|-|0.5|0.5|-|0.4597|0.45|0.434|0.417|
1/2|13|UNC|2A|1/2-13 UNC 2A|.500-13 UNC 2A|0.0015|0.4985|0.5|0.4876|0.4822|0.4485|0.4435|0.4069|-|
1/2|13|UNC|2B|1/2-13 UNC 2B|.500-13 UNC 2B|-|-|0.5|0.5|-|0.4565|0.45|0.434|0.417|
1/2|13|UNC|3A|1/2-13 UNC 3A|.500-13 UNC 3A|0|0.5|0.5|0.4891|-|0.45|0.4463|0.4084|-|
1/2|13|UNC|3B|1/2-13 UNC 3B|.500-13 UNC 3B|-|-|0.5|0.5|-|0.4548|0.45|0.4284|0.417|
1/2|14|UNS|2A|1/2-14 UNS 2A|.500-14 UNS 2A|0.0015|0.4985|0.5|0.4882|-|0.4521|0.4471|0.4135|-|
1/2|14|UNS|2B|1/2-14 UNS 2B|.500-14 UNS 2B|-|-|0.5|0.5|-|0.4601|0.4536|0.438|0.423|
1/2|16|UN|2A|1/2-16 UN 2A|.500-16 UN 2A|0.0014|0.4986|0.5|0.4892|-|0.458|0.4533|0.4241|-|
1/2|16|UN|2B|1/2-16 UN 2B|.500-16 UN 2B|-|-|0.5|0.5|-|0.4655|0.4594|0.446|0.432|
1/2|16|UN|3A|1/2-16 UN 3A|.500-16 UN 3A|0|0.5|0.5|0.4906|-|0.4594|0.4559|0.4255|-|
1/2|16|UN|3B|1/2-16 UN 3B|.500-16 UN 3B|-|-|0.5|0.5|-|0.464|0.4594|0.4419|0.432|
1/2|18|UNS|2A|1/2-18 UNS 2A|.500-18 UNS 2A|0.0013|0.4987|0.5|0.49|-|0.4626|0.4582|0.4326|-|
1/2|18|UNS|2B|1/2-18 UNS 2B|.500-18 UNS 2B|-|-|0.5|0.5|-|0.4697|0.4639|0.453|0.44|
1/2|20|UNF|1A|1/2-20 UNF 1A|.500-20 UNF 1A|0.0013|0.4987|0.5|0.4865|-|0.4662|0.4598|0.4392|-|
1/2|20|UNF|1B|1/2-20 UNF 1B|.500-20 UNF 1B|-|-|0.5|0.5|-|0.4759|0.4675|0.457|0.446|
1/2|20|UNF|2A|1/2-20 UNF 2A|.500-20 UNF 2A|0.0013|0.4987|0.5|0.4906|-|0.4662|0.4619|0.4392|-|
1/2|20|UNF|2B|1/2-20 UNF 2B|.500-20 UNF 2B|-|-|0.5|0.5|-|0.4731|0.4675|0.457|0.446|
1/2|20|UNF|3A|1/2-20 UNF 3A|.500-20 UNF 3A|0|0.5|0.5|0.4919|-|0.4675|0.4643|0.4405|-|
1/2|20|UNF|3B|1/2-20 UNF 3B|.500-20 UNF 3B|-|-|0.5|0.5|-|0.4717|0.4675|0.4537|0.446|
1/2|24|UNS|2A|1/2-24 UNS 2A|.500-24 UNS 2A|0.0012|0.4988|0.5|0.4916|-|0.4717|0.4678|0.4492|-|
1/2|24|UNS|2B|1/2-24 UNS 2B|.500-24 UNS 2B|-|-|0.5|0.5|-|0.478|0.4729|0.465|0.455|
1/2|27|UNS|2A|1/2-27 UNS 2A|.500-27 UNS 2A|0.0011|0.4989|0.5|0.4922|-|0.4748|0.4711|0.4548|-|
1/2|27|UNS|2B|1/2-27 UNS 2B|.500-27 UNS 2B|-|-|0.5|0.5|-|0.4807|0.4759|0.469|0.46|
1/2|28|UNEF|2A|1/2-28 UNEF 2A|.500-28 UNEF 2A|0.0011|0.4989|0.5|0.4924|-|0.4757|0.472|0.4563|-|
1/2|28|UNEF|2B|1/2-28 UNEF 2B|.500-28 UNEF 2B|-|-|0.5|0.5|-|0.4816|0.4768|0.47|0.461|
1/2|28|UNEF|3A|1/2-28 UNEF 3A|.500-28 UNEF 3A|0|0.5|0.5|0.4935|-|0.4768|0.474|0.4574|-|
1/2|28|UNEF|3B|1/2-28 UNEF 3B|.500-28 UNEF 3B|-|-|0.5|0.5|-|0.4804|0.4768|0.4676|0.461|
1/2|32|UN|2A|1/2-32 UN 2A|.500-32 UN 2A|0.001|0.499|0.5|0.493|-|0.4787|0.4752|0.4618|-|
1/2|32|UN|2B|1/2-32 UN 2B|.500-32 UN 2B|-|-|0.5|0.5|-|0.4842|0.4797|0.474|0.466|
1/2|32|UN|3A|1/2-32 UN 3A|.500-32 UN 3A|0|0.5|0.5|0.494|-|0.4797|0.4771|0.4628|-|
1/2|32|UN|3B|1/2-32 UN 3B|.500-32 UN 3B|-|-|0.5|0.5|-|0.4831|0.4797|0.4719|0.466|
9/16|12|UNC|1A|9/16-12 UNC 1A|.563-12 UNC 1A|0.0016|0.5609|0.5625|0.5437|-|0.5068|0.499|0.4617|-|
9/16|12|UNC|1B|9/16-12 UNC 1B|.563-12 UNC 1B|-|-|0.5625|0.5625|-|0.5186|0.5084|0.49|0.472|
9/16|12|UNC|2A|9/16-12 UNC 2A|.563-12 UNC 2A|0.0016|0.5609|0.5625|0.5495|0.5437|0.5068|0.5016|0.4617|-|
9/16|12|UNC|2B|9/16-12 UNC 2B|.563-12 UNC 2B|-|-|0.5625|0.5625|-|0.5152|0.5084|0.49|0.472|
9/16|12|UNC|3A|9/16-12 UNC 3A|.563-12 UNC 3A|0|0.5625|0.5625|0.5511|-|0.5084|0.5045|0.4633|-|
9/16|12|UNC|3B|9/16-12 UNC 3B|.563-12 UNC 3B|-|-|0.5625|0.5625|-|0.5135|0.5084|0.4843|0.472|
9/16|14|UNS|2A|9/16-14 UNS 2A|.563-14 UNS 2A|0.0015|0.561|0.5625|0.5507|-|0.5146|0.5096|0.476|-|
9/16|14|UNS|2B|9/16-14 UNS 2B|.563-14 UNS 2B|-|-|0.5625|0.5625|-|0.5226|0.5161|0.501|0.485|
9/16|16|UN|2A|9/16-16 UN 2A|.563-16 UN 2A|0.0014|0.5611|0.5625|0.5517|-|0.5205|0.5158|0.4866|-|
9/16|16|UN|2B|9/16-16 UN 2B|.563-16 UN 2B|-|-|0.5625|0.5625|-|0.528|0.5219|0.509|0.495|
9/16|16|UN|3A|9/16-16 UN 3A|.563-16 UN 3A|0|0.5625|0.5625|0.5531|-|0.5219|0.5184|0.488|-|
9/16|16|UN|3B|9/16-16 UN 3B|.563-16 UN 3B|-|-|0.5625|0.5625|-|0.5265|0.5219|0.504|0.495|
9/16|18|UNF|1A|9/16-18 UNF 1A|.563-18 UNF 1A|0.0014|0.5611|0.5625|0.548|-|0.525|0.5182|0.495|-|
9/16|18|UNF|1B|9/16-18 UNF 1B|.563-18 UNF 1B|-|-|0.5625|0.5625|-|0.5353|0.5264|0.515|0.502|
9/16|18|UNF|2A|9/16-18 UNF 2A|.563-18 UNF 2A|0.0014|0.5611|0.5625|0.5524|-|0.525|0.5205|0.495|-|
9/16|18|UNF|2B|9/16-18 UNF 2B|.563-18 UNF 2B|-|-|0.5625|0.5625|-|0.5323|0.5264|0.515|0.502|
9/16|18|UNF|3A|9/16-18 UNF 3A|.563-18 UNF 3A|0|0.5625|0.5625|0.5538|-|0.5264|0.523|0.4964|-|
9/16|18|UNF|3B|9/16-18 UNF 3B|.563-18 UNF 3B|-|-|0.5625|0.5625|-|0.5308|0.5264|0.5106|0.502|
9/16|20|UN|2A|9/16-20 UN 2A|.563-20 UN 2A|0.0013|0.5612|0.5625|0.5531|-|0.5287|0.5245|0.5017|-|
9/16|20|UN|2B|9/16-20 UN 2B|.563-20 UN 2B|-|-|0.5625|0.5625|-|0.5355|0.53|0.52|0.508|
9/16|20|UN|3A|9/16-20 UN 3A|.563-20 UN 3A|0|0.5625|0.5625|0.5544|-|0.53|0.5268|0.503|-|
9/16|20|UN|3B|9/16-20 UN 3B|.563-20 UN 3B|-|-|0.5625|0.5625|-|0.5341|0.53|0.5162|0.508|
9/16|24|UNEF|2A|9/16-24 UNEF 2A|.563-24 UNEF 2A|0.0012|0.5613|0.5625|0.5541|-|0.5342|0.5303|0.5117|-|
9/16|24|UNEF|2B|9/16-24 UNEF 2B|.563-24 UNEF 2B|-|-|0.5625|0.5625|-|0.5405|0.5354|0.527|0.517|
9/16|24|UNEF|3A|9/16-24 UNEF 3A|.563-24 UNEF 3A|0|0.5625|0.5625|0.5553|-|0.5354|0.5325|0.5129|-|
9/16|24|UNEF|3B|9/16-24 UNEF 3B|.563-24 UNEF 3B|-|-|0.5625|0.5625|-|0.5392|0.5354|0.5244|0.517|
9/16|27|UNS|2A|9/16-27 UNS 2A|.563-27 UNS 2A|0.0011|0.5614|0.5625|0.5547|-|0.5373|0.5336|0.5173|-|
9/16|27|UNS|2B|9/16-27 UNS 2B|.563-27 UNS 2B|-|-|0.5625|0.5625|-|0.5432|0.5384|0.531|0.522|
9/16|28|UN|2A|9/16-28 UN 2A|.563-28 UN 2A|0.0011|0.5614|0.5625|0.5549|-|0.5382|0.5345|0.5188|-|
9/16|28|UN|2B|9/16-28 UN 2B|.563-28 UN 2B|-|-|0.5625|0.5625|-|0.5441|0.5393|0.532|0.524|
9/16|28|UN|3A|9/16-28 UN 3A|.563-28 UN 3A|0|0.5625|0.5625|0.556|-|0.5393|0.5365|0.5199|-|
9/16|28|UN|3B|9/16-28 UN 3B|.563-28 UN 3B|-|-|0.5625|0.5625|-|0.5429|0.5393|0.5301|0.524|
9/16|32|UN|2A|9/16-32 UN 2A|.563-32 UN 2A|0.001|0.5615|0.5625|0.5555|-|0.5412|0.5377|0.5243|-|
9/16|32|UN|2B|9/16-32 UN 2B|.563-32 UN 2B|-|-|0.5625|0.5625|-|0.5467|0.5422|0.536|0.529|
9/16|32|UN|3A|9/16-32 UN 3A|.563-32 UN 3A|0|0.5625|0.5625|0.5565|-|0.5422|0.5396|0.5253|-|
9/16|32|UN|3B|9/16-32 UN 3B|.563-32 UN 3B|-|-|0.5625|0.5625|-|0.5456|0.5422|0.5344|0.529|
5/8|11|UNC|1A|5/8-11 UNC 1A|.625-11 UNC 1A|0.0016|0.6234|0.625|0.6052|-|0.5644|0.5561|0.5152|-|
5/8|11|UNC|1B|5/8-11 UNC 1B|.625-11 UNC 1B|-|-|0.625|0.625|-|0.5767|0.566|0.546|0.527|
5/8|11|UNC|2A|5/8-11 UNC 2A|.625-11 UNC 2A|0.0016|0.6234|0.625|0.6113|0.6052|0.5644|0.5589|0.5152|-|
5/8|11|UNC|2B|5/8-11 UNC 2B|.625-11 UNC 2B|-|-|0.625|0.625|-|0.5732|0.566|0.546|0.527|
5/8|11|UNC|3A|5/8-11 UNC 3A|.625-11 UNC 3A|0|0.625|0.625|0.6129|-|0.566|0.5619|0.5168|-|
5/8|11|UNC|3B|5/8-11 UNC 3B|.625-11 UNC 3B|-|-|0.625|0.625|-|0.5714|0.566|0.5391|0.527|
5/8|12|UN|2A|5/8-12 UN 2A|.625-12 UN 2A|0.0016|0.6234|0.625|0.612|-|0.5693|0.5639|0.5242|-|
5/8|12|UN|2B|5/8-12 UN 2B|.625-12 UN 2B|-|-|0.625|0.625|-|0.578|0.5709|0.553|0.535|
5/8|12|UN|3A|5/8-12 UN 3A|.625-12 UN 3A|0|0.625|0.625|0.6136|-|0.5709|0.5668|0.5258|-|
5/8|12|UN|3B|5/8-12 UN 3B|.625-12 UN 3B|-|-|0.625|0.625|-|0.5762|0.5709|0.5463|0.535|
5/8|14|UNS|2A|5/8-14 UNS 2A|.625-14 UNS 2A|0.0015|0.6235|0.625|0.6132|-|0.5771|0.572|0.5385|-|
5/8|14|UNS|2B|5/8-14 UNS 2B|.625-14 UNS 2B|-|-|0.625|0.625|-|0.5852|0.5786|0.564|0.548|
5/8|16|UN|2A|5/8-16 UN 2A|.625-16 UN 2A|0.0014|0.6236|0.625|0.6142|-|0.583|0.5782|0.5491|-|
5/8|16|UN|2B|5/8-16 UN 2B|.625-16 UN 2B|-|-|0.625|0.625|-|0.5906|0.5844|0.571|0.557|
5/8|16|UN|3A|5/8-16 UN 3A|.625-16 UN 3A|0|0.625|0.625|0.6156|-|0.5844|0.5808|0.5505|-|
5/8|16|UN|3B|5/8-16 UN 3B|.625-16 UN 3B|-|-|0.625|0.625|-|0.589|0.5844|0.5662|0.557|
5/8|18|UNF|1A|5/8-18 UNF 1A|.625-18 UNF 1A|0.0014|0.6236|0.625|0.6105|-|0.5875|0.5805|0.5575|-|
5/8|18|UNF|1B|5/8-18 UNF 1B|.625-18 UNF 1B|-|-|0.625|0.625|-|0.598|0.5889|0.578|0.565|
5/8|18|UNF|2A|5/8-18 UNF 2A|.625-18 UNF 2A|0.0014|0.6236|0.625|0.6149|-|0.5875|0.5828|0.5575|-|
5/8|18|UNF|2B|5/8-18 UNF 2B|.625-18 UNF 2B|-|-|0.625|0.625|-|0.5949|0.5889|0.578|0.565|
5/8|18|UNF|3A|5/8-18 UNF 3A|.625-18 UNF 3A|0|0.625|0.625|0.6163|-|0.5889|0.5854|0.5589|-|
5/8|18|UNF|3B|5/8-18 UNF 3B|.625-18 UNF 3B|-|-|0.625|0.625|-|0.5934|0.5889|0.573|0.565|
5/8|20|UN|2A|5/8-20 UN 2A|.625-20 UN 2A|0.0013|0.6237|0.625|0.6156|-|0.5912|0.5869|0.5642|-|
5/8|20|UN|2B|5/8-20 UN 2B|.625-20 UN 2B|-|-|0.625|0.625|-|0.5981|0.5925|0.582|0.571|
5/8|20|UN|3A|5/8-20 UN 3A|.625-20 UN 3A|0|0.625|0.625|0.6169|-|0.5925|0.5893|0.5655|-|
5/8|20|UN|3B|5/8-20 UN 3B|.625-20 UN 3B|-|-|0.625|0.625|-|0.5967|0.5925|0.5787|0.571|
5/8|24|UNEF|2A|5/8-24 UNEF 2A|.625-24 UNEF 2A|0.0012|0.6238|0.625|0.6166|-|0.5967|0.5927|0.5742|-|
5/8|24|UNEF|2B|5/8-24 UNEF 2B|.625-24 UNEF 2B|-|-|0.625|0.625|-|0.6031|0.5979|0.59|0.58|
5/8|24|UNEF|3A|5/8-24 UNEF 3A|.625-24 UNEF 3A|0|0.625|0.625|0.6178|-|0.5979|0.5949|0.5754|-|
5/8|24|UNEF|3B|5/8-24 UNEF 3B|.625-24 UNEF 3B|-|-|0.625|0.625|-|0.6018|0.5979|0.5869|0.58|
5/8|27|UNS|2A|5/8-27 UNS 2A|.625-27 UNS 2A|0.0011|0.6239|0.625|0.6172|-|0.5998|0.596|0.5798|-|
5/8|27|UNS|2B|5/8-27 UNS 2B|.625-27 UNS 2B|-|-|0.625|0.625|-|0.6059|0.6009|0.594|0.585|
5/8|28|UN|2A|5/8-28 UN 2A|.625-28 UN 2A|0.0011|0.6239|0.625|0.6174|-|0.6007|0.5969|0.5813|-|
5/8|28|UN|2B|5/8-28 UN 2B|.625-28 UN 2B|-|-|0.625|0.625|-|0.6067|0.6018|0.595|0.586|
5/8|28|UN|3A|5/8-28 UN 3A|.625-28 UN 3A|0|0.625|0.625|0.6185|-|0.6018|0.599|0.5824|-|
5/8|28|UN|3B|5/8-28 UN 3B|.625-28 UN 3B|-|-|0.625|0.625|-|0.6055|0.6018|0.5926|0.586|
5/8|32|UN|2A|5/8-32 UN 2A|.625-32 UN 2A|0.0011|0.6239|0.625|0.6179|-|0.6036|0.6|0.5867|-|
5/8|32|UN|2B|5/8-32 UN 2B|.625-32 UN 2B|-|-|0.625|0.625|-|0.6093|0.6047|0.599|0.591|
5/8|32|UN|3A|5/8-32 UN 3A|.625-32 UN 3A|0|0.625|0.625|0.619|-|0.6047|0.602|0.5878|-|
5/8|32|UN|3B|5/8-32 UN 3B|.625-32 UN 3B|-|-|0.625|0.625|-|0.6082|0.6047|0.5969|0.591|
11/16|12|UN|2A|11/16-12 UN 2A|.688-12 UN 2A|0.0016|0.6859|0.6875|0.6745|-|0.6318|0.6264|0.5867|-|
11/16|12|UN|2B|11/16-12 UN 2B|.688-12 UN 2B|-|-|0.6875|0.6875|-|0.6405|0.6334|0.615|0.597|
11/16|12|UN|3A|11/16-12 UN 3A|.688-12 UN 3A|0|0.6875|0.6875|0.6761|-|0.6334|0.6293|0.5883|-|
11/16|12|UN|3B|11/16-12 UN 3B|.688-12 UN 3B|-|-|0.6875|0.6875|-|0.6387|0.6334|0.6085|0.597|
11/16|16|UN|2A|11/16-16 UN 2A|.688-16 UN 2A|0.0014|0.6861|0.6875|0.6767|-|0.6455|0.6407|0.6116|-|
11/16|16|UN|2B|11/16-16 UN 2B|.688-16 UN 2B|-|-|0.6875|0.6875|-|0.6531|0.6469|0.634|0.62|
11/16|16|UN|3A|11/16-16 UN 3A|.688-16 UN 3A|0|0.6875|0.6875|0.6781|-|0.6469|0.6433|0.613|-|
11/16|16|UN|3B|11/16-16 UN 3B|.688-16 UN 3B|-|-|0.6875|0.6875|-|0.6515|0.6469|0.6284|0.62|
11/16|20|UN|2A|11/16-20 UN 2A|.688-20 UN 2A|0.0013|0.6862|0.6875|0.6781|-|0.6537|0.6494|0.6267|-|
11/16|20|UN|2B|11/16-20 UN 2B|.688-20 UN 2B|-|-|0.6875|0.6875|-|0.6606|0.655|0.645|0.633|
11/16|20|UN|3A|11/16-20 UN 3A|.688-20 UN 3A|0|0.6875|0.6875|0.6794|-|0.655|0.6518|0.628|-|
11/16|20|UN|3B|11/16-20 UN 3B|.688-20 UN 3B|-|-|0.6875|0.6875|-|0.6592|0.655|0.6412|0.633|
11/16|24|UNEF|2A|11/16-24 UNEF 2A|.688-24 UNEF 2A|0.0012|0.6863|0.6875|0.6791|-|0.6592|0.6552|0.6367|-|
11/16|24|UNEF|2B|11/16-24 UNEF 2B|.688-24 UNEF 2B|-|-|0.6875|0.6875|-|0.6656|0.6604|0.652|0.642|
11/16|24|UNEF|3A|11/16-24 UNEF 3A|.688-24 UNEF 3A|0|0.6875|0.6875|0.6803|-|0.6604|0.6574|0.6379|-|
11/16|24|UNEF|3B|11/16-24 UNEF 3B|.688-24 UNEF 3B|-|-|0.6875|0.6875|-|0.6643|0.6604|0.6494|0.642|
11/16|28|UN|2A|11/16-28 UN 2A|.688-28 UN 2A|0.0011|0.6864|0.6875|0.6799|-|0.6632|0.6594|0.6438|-|
11/16|28|UN|2B|11/16-28 UN 2B|.688-28 UN 2B|-|-|0.6875|0.6875|-|0.6692|0.6643|0.657|0.649|
11/16|28|UN|3A|11/16-28 UN 3A|.688-28 UN 3A|0|0.6875|0.6875|0.681|-|0.6643|0.6615|0.6449|-|
11/16|28|UN|3B|11/16-28 UN 3B|.688-28 UN 3B|-|-|0.6875|0.6875|-|0.668|0.6643|0.6551|0.649|
11/16|32|UN|2A|11/16-32 UN 2A|.688-32 UN 2A|0.0011|0.6864|0.6875|0.6804|-|0.6661|0.6625|0.6492|-|
11/16|32|UN|2B|11/16-32 UN 2B|.688-32 UN 2B|-|-|0.6875|0.6875|-|0.6718|0.6672|0.661|0.654|
11/16|32|UN|3A|11/16-32 UN 3A|.688-32 UN 3A|0|0.6875|0.6875|0.6815|-|0.6672|0.6645|0.6503|-|
11/16|32|UN|3B|11/16-32 UN 3B|.688-32 UN 3B|-|-|0.6875|0.6875|-|0.6707|0.6672|0.6594|0.654|
3/4|10|UNC|1A|3/4-10 UNC 1A|.750-10 UNC 1A|0.0018|0.7482|0.75|0.7288|-|0.6832|0.6744|0.6291|-|
3/4|10|UNC|1B|3/4-10 UNC 1B|.750-10 UNC 1B|-|-|0.75|0.75|-|0.6965|0.685|0.663|0.642|
3/4|10|UNC|2A|3/4-10 UNC 2A|.750-10 UNC 2A|0.0018|0.7482|0.75|0.7353|0.7288|0.6832|0.6773|0.6291|-|
3/4|10|UNC|2B|3/4-10 UNC 2B|.750-10 UNC 2B|-|-|0.75|0.75|-|0.6927|0.685|0.663|0.642|
3/4|10|UNC|3A|3/4-10 UNC 3A|.750-10 UNC 3A|0|0.75|0.75|0.7371|-|0.685|0.6806|0.6309|-|
3/4|10|UNC|3B|3/4-10 UNC 3B|.750-10 UNC 3B|-|-|0.75|0.75|-|0.6907|0.685|0.6545|0.642|
3/4|12|UN|2A|3/4-12 UN 2A|.750-12 UN 2A|0.0017|0.7483|0.75|0.7369|-|0.6942|0.6887|0.6491|-|
3/4|12|UN|2B|3/4-12 UN 2B|.750-12 UN 2B|-|-|0.75|0.75|-|0.7031|0.6959|0.678|0.66|
3/4|12|UN|3A|3/4-12 UN 3A|.750-12 UN 3A|0|0.75|0.75|0.7386|-|0.6959|0.6918|0.6508|-|
3/4|12|UN|3B|3/4-12 UN 3B|.750-12 UN 3B|-|-|0.75|0.75|-|0.7013|0.6959|0.6707|0.66|
3/4|14|UNS|2A|3/4-14 UNS 2A|.750-14 UNS 2A|0.0015|0.7485|0.75|0.7382|-|0.7021|0.697|0.6635|-|
3/4|14|UNS|2B|3/4-14 UNS 2B|.750-14 UNS 2B|-|-|0.75|0.75|-|0.7103|0.7036|0.688|0.673|
3/4|16|UNF|1A|3/4-16 UNF 1A|.750-16 UNF 1A|0.0015|0.7485|0.75|0.7343|-|0.7079|0.7004|0.674|-|
3/4|16|UNF|1B|3/4-16 UNF 1B|.750-16 UNF 1B|-|-|0.75|0.75|-|0.7192|0.7094|0.696|0.682|
3/4|16|UNF|2A|3/4-16 UNF 2A|.750-16 UNF 2A|0.0015|0.7485|0.75|0.7391|-|0.7079|0.7029|0.674|-|
3/4|16|UNF|2B|3/4-16 UNF 2B|.750-16 UNF 2B|-|-|0.75|0.75|-|0.7159|0.7094|0.696|0.682|
3/4|16|UNF|3A|3/4-16 UNF 3A|.750-16 UNF 3A|0|0.75|0.75|0.7406|-|0.7094|0.7056|0.6755|-|
3/4|16|UNF|3B|3/4-16 UNF 3B|.750-16 UNF 3B|-|-|0.75|0.75|-|0.7143|0.7094|0.6908|0.682|
3/4|18|UNS|2A|3/4-18 UNS 2A|.750-18 UNS 2A|0.0014|0.7486|0.75|0.7399|-|0.7125|0.7079|0.6825|-|
3/4|18|UNS|2B|3/4-18 UNS 2B|.750-18 UNS 2B|-|-|0.75|0.75|-|0.7199|0.7139|0.703|0.69|
3/4|20|UNEF|2A|3/4-20 UNEF 2A|.750-20 UNEF 2A|0.0013|0.7487|0.75|0.7406|-|0.7162|0.7118|0.6892|-|
3/4|20|UNEF|2B|3/4-20 UNEF 2B|.750-20 UNEF 2B|-|-|0.75|0.75|-|0.7232|0.7175|0.707|0.696|
3/4|20|UNEF|3A|3/4-20 UNEF 3A|.750-20 UNEF 3A|0|0.75|0.75|0.7419|-|0.7175|0.7142|0.6905|-|
3/4|20|UNEF|3B|3/4-20 UNEF 3B|.750-20 UNEF 3B|-|-|0.75|0.75|-|0.7218|0.7175|0.7037|0.696|
3/4|24|UNS|2A|3/4-24 UNS 2A|.750-24 UNS 2A|0.0012|0.7488|0.75|0.7416|-|0.7217|0.7176|0.6992|-|
3/4|24|UNS|2B|3/4-24 UNS 2B|.750-24 UNS 2B|-|-|0.75|0.75|-|0.7282|0.7229|0.715|0.705|
3/4|27|UNS|2A|3/4-27 UNS 2A|.750-27 UNS 2A|0.0012|0.7488|0.75|0.7421|-|0.7247|0.7208|0.7047|-|
3/4|27|UNS|2B|3/4-27 UNS 2B|.750-27 UNS 2B|-|-|0.75|0.75|-|0.731|0.7259|0.719|0.71|
3/4|28|UN|2A|3/4-28 UN 2A|.750-28 UN 2A|0.0012|0.7488|0.75|0.7423|-|0.7256|0.7218|0.7062|-|
3/4|28|UN|2B|3/4-28 UN 2B|.750-28 UN 2B|-|-|0.75|0.75|-|0.7318|0.7268|0.72|0.711|
3/4|28|UN|3A|3/4-28 UN 3A|.750-28 UN 3A|0|0.75|0.75|0.7435|-|0.7268|0.7239|0.7074|-|
3/4|28|UN|3B|3/4-28 UN 3B|.750-28 UN 3B|-|-|0.75|0.75|-|0.7305|0.7268|0.7176|0.711|
3/4|32|UN|2A|3/4-32 UN 2A|.750-32 UN 2A|0.0011|0.7489|0.75|0.7429|-|0.7286|0.725|0.7117|-|
3/4|32|UN|2B|3/4-32 UN 2B|.750-32 UN 2B|-|-|0.75|0.75|-|0.7344|0.7297|0.724|0.716|
3/4|32|UN|3A|3/4-32 UN 3A|.750-32 UN 3A|0|0.75|0.75|0.744|-|0.7297|0.727|0.7128|-|
3/4|32|UN|3B|3/4-32 UN 3B|.750-32 UN 3B|-|-|0.75|0.75|-|0.7333|0.7297|0.7219|0.716|
13/16|12|UN|2A|13/16-12 UN 2A|.813-12 UN 2A|0.0017|0.8108|0.8125|0.7994|-|0.7567|0.7512|0.7116|-|
13/16|12|UN|2B|13/16-12 UN 2B|.813-12 UN 2B|-|-|0.8125|0.8125|-|0.7656|0.7584|0.74|0.722|
13/16|12|UN|3A|13/16-12 UN 3A|.813-12 UN 3A|0|0.8125|0.8125|0.8011|-|0.7584|0.7543|0.7133|-|
13/16|12|UN|3B|13/16-12 UN 3B|.813-12 UN 3B|-|-|0.8125|0.8125|-|0.7638|0.7584|0.7329|0.722|
13/16|16|UN|2A|13/16-16 UN 2A|.813-16 UN 2A|0.0015|0.811|0.8125|0.8016|-|0.7704|0.7655|0.7365|-|
13/16|16|UN|2B|13/16-16 UN 2B|.813-16 UN 2B|-|-|0.8125|0.8125|-|0.7782|0.7719|0.759|0.745|
13/16|16|UN|3A|13/16-16 UN 3A|.813-16 UN 3A|0|0.8125|0.8125|0.8031|-|0.7719|0.7683|0.738|-|
13/16|16|UN|3B|13/16-16 UN 3B|.813-16 UN 3B|-|-|0.8125|0.8125|-|0.7766|0.7719|0.7533|0.745|
13/16|20|UNEF|2A|13/16-20 UNEF 2A|.813-20 UNEF 2A|0.0013|0.8112|0.8125|0.8031|-|0.7787|0.7743|0.7517|-|
13/16|20|UNEF|2B|13/16-20 UNEF 2B|.813-20 UNEF 2B|-|-|0.8125|0.8125|-|0.7857|0.78|0.77|0.758|
13/16|20|UNEF|3A|13/16-20 UNEF 3A|.813-20 UNEF 3A|0|0.8125|0.8125|0.8044|-|0.78|0.7767|0.753|-|
13/16|20|UNEF|3B|13/16-20 UNEF 3B|.813-20 UNEF 3B|-|-|0.8125|0.8125|-|0.7843|0.78|0.7662|0.758|
13/16|28|UN|2A|13/16-28 UN 2A|.813-28 UN 2A|0.0012|0.8113|0.8125|0.8048|-|0.7881|0.7843|0.7687|-|
13/16|28|UN|2B|13/16-28 UN 2B|.813-28 UN 2B|-|-|0.8125|0.8125|-|0.7943|0.7893|0.782|0.774|
13/16|28|UN|3A|13/16-28 UN 3A|.813-28 UN 3A|0|0.8125|0.8125|0.806|-|0.7893|0.7864|0.7699|-|
13/16|28|UN|3B|13/16-28 UN 3B|.813-28 UN 3B|-|-|0.8125|0.8125|-|0.793|0.7893|0.7801|0.774|
13/16|32|UN|2A|13/16-32 UN 2A|.813-32 UN 2A|0.0011|0.8114|0.8125|0.8054|-|0.7911|0.7875|0.7742|-|
13/16|32|UN|2B|13/16-32 UN 2B|.813-32 UN 2B|-|-|0.8125|0.8125|-|0.7969|0.7922|0.786|0.779|
13/16|32|UN|3A|13/16-32 UN 3A|.813-32 UN 3A|0|0.8125|0.8125|0.8065|-|0.7922|0.7895|0.7753|-|
13/16|32|UN|3B|13/16-32 UN 3B|.813-32 UN 3B|-|-|0.8125|0.8125|-|0.7958|0.7922|0.7844|0.779|
7/8|9|UNC|1A|7/8-9 UNC 1A|.875-9 UNC 1A|0.0019|0.8731|0.875|0.8523|-|0.8009|0.7914|0.7408|-|
7/8|9|UNC|1B|7/8-9 UNC 1B|.875-9 UNC 1B|-|-|0.875|0.875|-|0.8151|0.8028|0.778|0.755|
7/8|9|UNC|2A|7/8-9 UNC 2A|.875-9 UNC 2A|0.0019|0.8731|0.875|0.8592|0.8523|0.8009|0.7946|0.7408|-|
7/8|9|UNC|2B|7/8-9 UNC 2B|.875-9 UNC 2B|-|-|0.875|0.875|-|0.811|0.8028|0.778|0.755|
7/8|9|UNC|3A|7/8-9 UNC 3A|.875-9 UNC 3A|0|0.875|0.875|0.8611|-|0.8028|0.7981|0.7427|-|
7/8|9|UNC|3B|7/8-9 UNC 3B|.875-9 UNC 3B|-|-|0.875|0.875|-|0.8089|0.8028|0.7681|0.755|
7/8|10|UNS|2A|7/8-10 UNS 2A|.875-10 UNS 2A|0.0018|0.8732|0.875|0.8603|-|0.8082|0.8022|0.7542|-|
7/8|10|UNS|2B|7/8-10 UNS 2B|.875-10 UNS 2B|-|-|0.875|0.875|-|0.8178|0.81|0.788|0.767|
7/8|12|UN|2A|7/8-12 UN 2A|.875-12 UN 2A|0.0017|0.8733|0.875|0.8619|-|0.8192|0.8137|0.7741|-|
7/8|12|UN|2B|7/8-12 UN 2B|.875-12 UN 2B|-|-|0.875|0.875|-|0.8281|0.8209|0.803|0.785|
7/8|12|UN|3A|7/8-12 UN 3A|.875-12 UN 3A|0|0.875|0.875|0.8636|-|0.8209|0.8168|0.7758|-|
7/8|12|UN|3B|7/8-12 UN 3B|.875-12 UN 3B|-|-|0.875|0.875|-|0.8263|0.8209|0.7948|0.785|
7/8|14|UNF|1A|7/8-14 UNF 1A|.875-14 UNF 1A|0.0016|0.8734|0.875|0.8579|-|0.827|0.8189|0.7884|-|
7/8|14|UNF|1B|7/8-14 UNF 1B|.875-14 UNF 1B|-|-|0.875|0.875|-|0.8392|0.8286|0.814|0.798|
7/8|14|UNF|2A|7/8-14 UNF 2A|.875-14 UNF 2A|0.0016|0.8734|0.875|0.8631|-|0.827|0.8216|0.7884|-|
7/8|14|UNF|2B|7/8-14 UNF 2B|.875-14 UNF 2B|-|-|0.875|0.875|-|0.8356|0.8286|0.814|0.798|
7/8|14|UNF|3A|7/8-14 UNF 3A|.875-14 UNF 3A|0|0.875|0.875|0.8647|-|0.8286|0.8245|0.79|-|
7/8|14|UNF|3B|7/8-14 UNF 3B|.875-14 UNF 3B|-|-|0.875|0.875|-|0.8339|0.8286|0.8068|0.798|
7/8|16|UN|2A|7/8-16 UN 2A|.875-16 UN 2A|0.0015|0.8735|0.875|0.8641|-|0.8329|0.828|0.79|-|
7/8|16|UN|2B|7/8-16 UN 2B|.875-16 UN 2B|-|-|0.875|0.875|-|0.8407|0.8344|0.821|0.807|
7/8|16|UN|3A|7/8-16 UN 3A|.875-16 UN 3A|0|0.875|0.875|0.8656|-|0.8344|0.8308|0.8005|-|
7/8|16|UN|3B|7/8-16 UN 3B|.875-16 UN 3B|-|-|0.875|0.875|-|0.8391|0.8344|0.8158|0.807|
7/8|18|UNS|2A|7/8-18 UNS 2A|.875-18 UNS 2A|0.0014|0.8736|0.875|0.8649|-|0.8375|0.8329|0.8075|-|
7/8|18|UNS|2B|7/8-18 UNS 2B|.875-18 UNS 2B|-|-|0.875|0.875|-|0.8449|0.8389|0.828|0.815|
7/8|20|UNEF|2A|7/8-20 UNEF 2A|.875-20 UNEF 2A|0.0013|0.8737|0.875|0.8656|-|0.8412|0.8368|0.8142|-|
7/8|20|UNEF|2B|7/8-20 UNEF 2B|.875-20 UNEF 2B|-|-|0.875|0.875|-|0.8482|0.8425|0.832|0.821|
7/8|20|UNEF|3A|7/8-20 UNEF 3A|.875-20 UNEF 3A|0|0.875|0.875|0.8669|-|0.8425|0.8392|0.8155|-|
7/8|20|UNEF|3B|7/8-20 UNEF 3B|.875-20 UNEF 3B|-|-|0.875|0.875|-|0.8468|0.8425|0.8287|0.821|
7/8|24|UNS|2A|7/8-24 UNS 2A|.875-24 UNS 2A|0.0012|0.8738|0.875|0.8666|-|0.8467|0.8426|0.8242|-|
7/8|24|UNS|2B|7/8-24 UNS 2B|.875-24 UNS 2B|-|-|0.875|0.875|-|0.8532|0.8479|0.84|0.83|
7/8|27|UNS|2A|7/8-27 UNS 2A|.875-27 UNS 2A|0.0012|0.8738|0.875|0.8671|-|0.8497|0.8458|0.8297|-|
7/8|27|UNS|2B|7/8-27 UNS 2B|.875-27 UNS 2B|-|-|0.875|0.875|-|0.856|0.8509|0.844|0.835|
7/8|28|UN|2A|7/8-28 UN 2A|.875-28 UN 2A|0.0012|0.8738|0.875|0.8673|-|0.8506|0.8468|0.8312|-|
7/8|28|UN|2B|7/8-28 UN 2B|.875-28 UN 2B|-|-|0.875|0.875|-|0.8568|0.8518|0.845|0.836|
7/8|28|UN|3A|7/8-28 UN 3A|.875-28 UN 3A|0|0.875|0.875|0.8685|-|0.8518|0.8489|0.8324|-|
7/8|28|UN|3B|7/8-28 UN 3B|.875-28 UN 3B|-|-|0.875|0.875|-|0.8555|0.8518|0.8426|0.836|
7/8|32|UN|2A|7/8-32 UN 2A|.875-32 UN 2A|0.0011|0.8739|0.875|0.8679|-|0.8536|0.85|0.8367|-|
7/8|32|UN|2B|7/8-32 UN 2B|.875-32 UN 2B|-|-|0.875|0.875|-|0.8594|0.8547|0.849|0.841|
7/8|32|UN|3A|7/8-32 UN 3A|.875-32 UN 3A|0|0.875|0.875|0.869|-|0.8547|0.852|0.8378|-|
7/8|32|UN|3B|7/8-32 UN 3B|.875-32 UN 3B|-|-|0.875|0.875|-|0.8583|0.8547|0.8469|0.841|
15/16|12|UN|2A|15/16-12 UN 2A|.938-12 UN 2A|0.0017|0.9358|0.9375|0.9244|-|0.8817|0.876|0.8366|-|
15/16|12|UN|2B|15/16-12 UN 2B|.938-12 UN 2B|-|-|0.9375|0.9375|-|0.8908|0.8834|0.865|0.847|
15/16|12|UN|3A|15/16-12 UN 3A|.938-12 UN 3A|0|0.9375|0.9375|0.9261|-|0.8834|0.8793|0.8383|-|
15/16|12|UN|3B|15/16-12 UN 3B|.938-12 UN 3B|-|-|0.9375|0.9375|-|0.8889|0.8834|0.8575|0.847|
15/16|16|UN|2A|15/16-16 UN 2A|.938-16 UN 2A|0.0015|0.936|0.9375|0.9266|-|0.8954|0.8904|0.8615|-|
15/16|16|UN|2B|15/16-16 UN 2B|.938-16 UN 2B|-|-|0.9375|0.9375|-|0.9034|0.8969|0.884|0.87|
15/16|16|UN|3A|15/16-16 UN 3A|.938-16 UN 3A|0|0.9375|0.9375|0.9281|-|0.8969|0.8932|0.863|-|
15/16|16|UN|3B|15/16-16 UN 3B|.938-16 UN 3B|-|-|0.9375|0.9375|-|0.9018|0.8969|0.8783|0.87|
15/16|20|UNEF|2A|15/16-20 UNEF 2A|.938-20 UNEF 2A|0.0014|0.9361|0.9375|0.928|-|0.9036|0.8991|0.8766|-|
15/16|20|UNEF|2B|15/16-20 UNEF 2B|.938-20 UNEF 2B|-|-|0.9375|0.9375|-|0.9109|0.905|0.895|0.883|
15/16|20|UNEF|3A|15/16-20 UNEF 3A|.938-20 UNEF 3A|0|0.9375|0.9375|0.9294|-|0.905|0.9016|0.878|-|
15/16|20|UNEF|3B|15/16-20 UNEF 3B|.938-20 UNEF 3B|-|-|0.9375|0.9375|-|0.9094|0.905|0.8912|0.883|
15/16|28|UN|2A|15/16-28 UN 2A|.938-28 UN 2A|0.0012|0.9363|0.9375|0.9298|-|0.9131|0.9091|0.8937|-|
15/16|28|UN|2B|15/16-28 UN 2B|.938-28 UN 2B|-|-|0.9375|0.9375|-|0.9195|0.9143|0.907|0.899|
15/16|28|UN|3A|15/16-28 UN 3A|.938-28 UN 3A|0|0.9375|0.9375|0.931|-|0.9143|0.9113|0.8949|-|
15/16|28|UN|3B|15/16-28 UN 3B|.938-28 UN 3B|-|-|0.9375|0.9375|-|0.9182|0.9143|0.9051|0.899|
15/16|32|UN|2A|15/16-32 UN 2A|.938-32 UN 2A|0.0011|0.9364|0.9375|0.9304|-|0.9161|0.9123|0.8992|-|
15/16|32|UN|2B|15/16-32 UN 2B|.938-32 UN 2B|-|-|0.9375|0.9375|-|0.9221|0.9172|0.911|0.904|
15/16|32|UN|3A|15/16-32 UN 3A|.938-32 UN 3A|0|0.9375|0.9375|0.9315|-|0.9172|0.9144|0.9003|-|
15/16|32|UN|3B|15/16-32 UN 3B|.938-32 UN 3B|-|-|0.9375|0.9375|-|0.9209|0.9172|0.9094|0.904|
1|8|UNC|1A|1-8 UNC 1A|1.000-8 UNC 1A|0.002|0.998|1|0.9755|-|0.9168|0.9067|0.8492|-|
1|8|UNC|1B|1-8 UNC 1B|1.000-8 UNC 1B|-|-|1|1|-|0.932|0.9188|0.89|0.865|
1|8|UNC|2A|1-8 UNC 2A|1.000-8 UNC 2A|0.002|0.998|1|0.983|0.9755|0.9168|0.91|0.8492|-|
1|8|UNC|2B|1-8 UNC 2B|1.000-8 UNC 2B|-|-|1|1|-|0.9276|0.9188|0.89|0.865|
1|8|UNC|3A|1-8 UNC 3A|1.000-8 UNC 3A|0|1|1|0.985|-|0.9188|0.9137|0.8512|-|
1|8|UNC|3B|1-8 UNC 3B|1.000-8 UNC 3B|-|-|1|1|-|0.9254|0.9188|0.8797|0.865|
1|10|UNS|2A|1-10 UNS 2A|1.000-10 UNS 2A|0.0018|0.9982|1|0.9853|-|0.9332|0.927|0.8792|-|
1|10|UNS|2B|1-10 UNS 2B|1.000-10 UNS 2B|-|-|1|1|-|0.943|0.935|0.913|0.892|
1|12|UNF|1A|1-12 UNF 1A|1.000-12 UNF 1A|0.0018|0.9982|1|0.981|-|0.9441|0.9353|0.899|-|
1|12|UNF|1B|1-12 UNF 1B|1.000-12 UNF 1B|-|-|1|1|-|0.9573|0.9459|0.928|0.91|
1|12|UNF|2A|1-12 UNF 2A|1.000-12 UNF 2A|0.0018|0.9982|1|0.9868|-|0.9441|0.9382|0.899|-|
1|12|UNF|2B|1-12 UNF 2B|1.000-12 UNF 2B|-|-|1|1|-|0.9535|0.9459|0.928|0.91|
1|12|UNF|3A|1-12 UNF 3A|1.000-12 UNF 3A|0|1|1|0.9886|-|0.9459|0.9415|0.9008|-|
1|12|UNF|3B|1-12 UNF 3B|1.000-12 UNF 3B|-|-|1|1|-|0.9516|0.9459|0.9198|0.91|
1|14|UNS|1A|1-14 UNS 1A|1.000-14 UNS 1A|0.0017|0.9983|1|0.9828|-|0.9519|0.9435|0.9132|-|
1|14|UNS|1B|1-14 UNS 1B|1.000-14 UNS 1B|-|-|1|1|-|0.9645|0.9536|0.938|0.923|
1|14|UNS|2A|1-14 UNS 2A|1.000-14 UNS 2A|0.0017|0.9983|1|0.988|-|0.9519|0.9463|0.9132|-|
1|14|UNS|2B|1-14 UNS 2B|1.000-14 UNS 2B|-|-|1|1|-|0.9609|0.9536|0.938|0.923|
1|14|UNS|3A|1-14 UNS 3A|1.000-14 UNS 3A|0|1|1|0.9897|-|0.9536|0.9494|0.9149|-|
1|14|UNS|3B|1-14 UNS 3B|1.000-14 UNS 3B|-|-|1|1|-|0.959|0.9536|0.9315|0.923|
1|16|UN|2A|1-16 UN 2A|1.000-16 UN 2A|0.0015|0.9985|1|0.9891|-|0.9579|0.9529|0.924|-|
1|16|UN|2B|1-16 UN 2B|1.000-16 UN 2B|-|-|1|1|-|0.9659|0.9594|0.946|0.932|
1|16|UN|3A|1-16 UN 3A|1.000-16 UN 3A|0|1|1|0.9906|-|0.9594|0.9557|0.9255|-|
1|16|UN|3B|1-16 UN 3B|1.000-16 UN 3B|-|-|1|1|-|0.9643|0.9594|0.9408|0.932|
1|18|UNS|2A|1-18 UNS 2A|1.000-18 UNS 2A|0.0014|0.9986|1|0.9899|-|0.9625|0.9578|0.9325|-|
1|18|UNS|2B|1-18 UNS 2B|1.000-18 UNS 2B|-|-|1|1|-|0.9701|0.9639|0.953|0.94|
1|20|UNEF|2A|1-20 UNEF 2A|1.000-20 UNEF 2A|0.0014|0.9986|1|0.9905|-|0.9661|0.9616|0.9391|-|
1|20|UNEF|2B|1-20 UNEF 2B|1.000-20 UNEF 2B|-|-|1|1|-|0.9734|0.9675|0.957|0.946|
1|20|UNEF|3A|1-20 UNEF 3A|1.000-20 UNEF 3A|0|1|1|0.9919|-|0.9675|0.9641|0.9405|-|
1|20|UNEF|3B|1-20 UNEF 3B|1.000-20 UNEF 3B|-|-|1|1|-|0.9719|0.9675|0.9537|0.946|
1|24|UNS|2A|1-24 UNS 2A|1.000-24 UNS 2A|0.0013|0.9987|1|0.9915|-|0.9716|0.9674|0.9491|-|
1|24|UNS|2B|1-24 UNS 2B|1.000-24 UNS 2B|-|-|1|1|-|0.9784|0.9729|0.965|0.955|
1|27|UNS|2A|1-27 UNS 2A|1.000-27 UNS 2A|0.0012|0.9988|1|0.9921|-|0.9747|0.9707|0.9547|-|
1|27|UNS|2B|1-27 UNS 2B|1.000-27 UNS 2B|-|-|1|1|-|0.9811|0.9759|0.969|0.96|
1|28|UN|2A|1-28 UN 2A|1.000-28 UN 2A|0.0012|0.9988|1|0.9923|-|0.9756|0.9716|0.9562|-|
1|28|UN|2B|1-28 UN 2B|1.000-28 UN 2B|-|-|1|1|-|0.982|0.9768|0.97|0.961|
1|28|UN|3A|1-28 UN 3A|1.000-28 UN 3A|0|1|1|0.9935|-|0.9768|0.9738|0.9574|-|
1|28|UN|3B|1-28 UN 3B|1.000-28 UN 3B|-|-|1|1|-|0.9807|0.9768|0.9676|0.961|
1|32|UN|2A|1-32 UN 2A|1.000-32 UN 2A|0.0011|0.9989|1|0.9929|-|0.9786|0.9748|0.9617|-|
1|32|UN|2B|1-32 UN 2B|1.000-32 UN 2B|-|-|1|1|-|0.9846|0.9797|0.974|0.966|
1|32|UN|3A|1-32 UN 3A|1.000-32 UN 3A|0|1|1|0.994|-|0.9797|0.9769|0.9628|-|
1|32|UN|3B|1-32 UN 3B|1.000-32 UN 3B|-|-|1|1|-|0.9834|0.9797|0.9719|0.966|
1 1/16|8|UN|2A|1 1/16-8 UN 2A|1.063-8 UN 2A|0.002|1.0605|1.0625|1.0455|-|0.9793|0.9725|0.9117|-|
1 1/16|8|UN|2B|1 1/16-8 UN 2B|1.063-8 UN 2B|-|-|1.0625|1.0625|-|0.9902|0.9813|0.952|0.927|
1 1/16|8|UN|3A|1 1/16-8 UN 3A|1.063-8 UN 3A|0|1.0625|1.0625|1.0475|-|0.9813|0.9762|0.9137|-|
1 1/16|8|UN|3B|1 1/16-8 UN 3B|1.063-8 UN 3B|-|-|1.0625|1.0625|-|0.988|0.9813|0.9422|0.927|
1 1/16|12|UN|2A|1 1/16-12 UN 2A|1.063-12 UN 2A|0.0017|1.0608|1.0625|1.0494|-|1.0067|1.001|0.9616|-|
1 1/16|12|UN|2B|1 1/16-12 UN 2B|1.063-12 UN 2B|-|-|1.0625|1.0625|-|1.0158|1.0084|0.99|0.972|
1 1/16|12|UN|3A|1 1/16-12 UN 3A|1.063-12 UN 3A|0|1.0625|1.0625|1.0511|-|1.0084|1.0042|0.9633|-|
1 1/16|12|UN|3B|1 1/16-12 UN 3B|1.063-12 UN 3B|-|-|1.0625|1.0625|-|1.0139|1.0084|0.9823|0.972|
1 1/16|16|UN|2A|1 1/16-16 UN 2A|1.063-16 UN 2A|0.0015|1.061|1.0625|1.0516|-|1.0204|1.0154|0.9865|-|
1 1/16|16|UN|2B|1 1/16-16 UN 2B|1.063-16 UN 2B|-|-|1.0625|1.0625|-|1.0284|1.0219|1.009|0.995|
1 1/16|16|UN|3A|1 1/16-16 UN 3A|1.063-16 UN 3A|0|1.0625|1.0625|1.0531|-|1.0219|1.0182|0.988|-|
1 1/16|16|UN|3B|1 1/16-16 UN 3B|1.063-16 UN 3B|-|-|1.0625|1.0625|-|1.0268|1.0219|1.0033|0.995|
1 1/16|18|UNEF|2A|1 1/16-18 UNEF 2A|1.063-18 UNEF 2A|0.0014|1.0611|1.0625|1.0524|-|1.025|1.0203|0.995|-|
1 1/16|18|UNEF|2B|1 1/16-18 UNEF 2B|1.063-18 UNEF 2B|-|-|1.0625|1.0625|-|1.0326|1.0264|1.015|1.002|
1 1/16|18|UNEF|3A|1 1/16-18 UNEF 3A|1.063-18 UNEF 3A|0|1.0625|1.0625|1.0538|-|1.0264|1.0228|0.9964|-|
1 1/16|18|UNEF|3B|1 1/16-18 UNEF 3B|1.063-18 UNEF 3B|-|-|1.0625|1.0625|-|1.031|1.0264|1.0105|1.002|
1 1/16|20|UN|2A|1 1/16-20 UN 2A|1.063-20 UN 2A|0.0014|1.0611|1.0625|1.053|-|1.0286|1.0241|1.0016|-|
1 1/16|20|UN|2B|1 1/16-20 UN 2B|1.063-20 UN 2B|-|-|1.0625|1.0625|-|1.0359|1.03|1.02|1.008|
1 1/16|20|UN|3A|1 1/16-20 UN 3A|1.063-20 UN 3A|0|1.0625|1.0625|1.0544|-|1.03|1.0266|1.003|-|
1 1/16|20|UN|3B|1 1/16-20 UN 3B|1.063-20 UN 3B|-|-|1.0625|1.0625|-|1.0344|1.03|1.0162|1.008|
1 1/16|28|UN|2A|1 1/16-28 UN 2A|1.063-28 UN 2A|0.0012|1.0613|1.0625|1.0548|-|1.0381|1.0341|1.0187|-|
1 1/16|28|UN|2B|1 1/16-28 UN 2B|1.063-28 UN 2B|-|-|1.0625|1.0625|-|1.0445|1.0393|1.032|1.024|
1 1/16|28|UN|3A|1 1/16-28 UN 3A|1.063-28 UN 3A|0|1.0625|1.0625|1.056|-|1.0393|1.0363|1.0199|-|
1 1/16|28|UN|3B|1 1/16-28 UN 3B|1.063-28 UN 3B|-|-|1.0625|1.0625|-|1.0432|1.0393|1.0301|1.024|
1 1/8|7|UNC|1A|1 1/8-7 UNC 1A|1.125-7 UNC 1A|0.0022|1.1228|1.125|1.0982|-|1.03|1.0191|0.9527|-|
1 1/8|7|UNC|1B|1 1/8-7 UNC 1B|1.125-7 UNC 1B|-|-|1.125|1.125|-|1.0463|1.0322|0.998|0.97|
1 1/8|7|UNC|2A|1 1/8-7 UNC 2A|1.125-7 UNC 2A|0.0022|1.1228|1.125|1.1064|1.0982|1.03|1.0228|0.9527|-|
1 1/8|7|UNC|2B|1 1/8-7 UNC 2B|1.125-7 UNC 2B|-|-|1.125|1.125|-|1.0416|1.0322|0.998|0.97|
1 1/8|7|UNC|3A|1 1/8-7 UNC 3A|1.125-7 UNC 3A|0|1.125|1.125|1.1086|-|1.0322|1.0268|0.9549|-|
1 1/8|7|UNC|3B|1 1/8-7 UNC 3B|1.125-7 UNC 3B|-|-|1.125|1.125|-|1.0393|1.0322|0.9875|0.97|
1 1/8|8|UN|2A|1 1/8-8 UN 2A|1.125-8 UN 2A|0.0021|1.1229|1.125|1.1079|1.1004|1.0417|1.0348|0.9741|-|
1 1/8|8|UN|2B|1 1/8-8 UN 2B|1.125-8 UN 2B|-|-|1.125|1.125|-|1.0528|1.0438|1.015|0.99|
1 1/8|8|UN|3A|1 1/8-8 UN 3A|1.125-8 UN 3A|0|1.125|1.125|1.11|-|1.0438|1.0386|0.9762|-|
1 1/8|8|UN|3B|1 1/8-8 UN 3B|1.125-8 UN 3B|-|-|1.125|1.125|-|1.0505|1.0438|1.0047|0.99|
1 1/8|10|UNS|2A|1 1/8-10 UNS 2A|1.125-10 UNS 2A|0.0018|1.1232|1.125|1.1103|-|1.0582|1.052|1.0042|-|
1 1/8|10|UNS|2B|1 1/8-10 UNS 2B|1.125-10 UNS 2B|-|-|1.125|1.125|-|1.068|1.06|1.038|1.017|
1 1/8|12|UNF|1A|1 1/8-12 UNF 1A|1.125-12 UNF 1A|0.0018|1.1232|1.125|1.106|-|1.0691|1.0601|1.024|-|
1 1/8|12|UNF|1B|1 1/8-12 UNF 1B|1.125-12 UNF 1B|-|-|1.125|1.125|-|1.0826|1.0709|1.053|1.035|
1 1/8|12|UNF|2A|1 1/8-12 UNF 2A|1.125-12 UNF 2A|0.0018|1.1232|1.125|1.1118|-|1.0691|1.0631|1.024|-|
1 1/8|12|UNF|2B|1 1/8-12 UNF 2B|1.125-12 UNF 2B|-|-|1.125|1.125|-|1.0787|1.0709|1.053|1.035|
1 1/8|12|UNF|3A|1 1/8-12 UNF 3A|1.125-12 UNF 3A|0|1.125|1.125|1.1136|-|1.0709|1.0664|1.0258|-|
1 1/8|12|UNF|3B|1 1/8-12 UNF 3B|1.125-12 UNF 3B|-|-|1.125|1.125|-|1.0768|1.0709|1.0448|1.035|
1 1/8|14|UNS|2A|1 1/8-14 UNS 2A|1.125-14 UNS 2A|0.0016|1.1234|1.125|1.1131|-|1.077|1.0717|1.0384|-|
1 1/8|14|UNS|2B|1 1/8-14 UNS 2B|1.125-14 UNS 2B|-|-|1.125|1.125|-|1.0855|1.0786|1.064|1.048|
1 1/8|16|UN|2A|1 1/8-16 UN 2A|1.125-16 UN 2A|0.0015|1.1235|1.125|1.1141|-|1.0829|1.0779|1.049|-|
1 1/8|16|UN|2B|1 1/8-16 UN 2B|1.125-16 UN 2B|-|-|1.125|1.125|-|1.0909|1.0844|1.071|1.057|
1 1/8|16|UN|3A|1 1/8-16 UN 3A|1.125-16 UN 3A|0|1.125|1.125|1.1156|-|1.0844|1.0807|1.0505|-|
1 1/8|16|UN|3B|1 1/8-16 UN 3B|1.125-16 UN 3B|-|-|1.125|1.125|-|1.0893|1.0844|1.0658|1.057|
1 1/8|18|UNEF|2A|1 1/8-18 UNEF 2A|1.125-18 UNEF 2A|0.0014|1.1236|1.125|1.1149|-|1.0875|1.0828|1.0575|-|
1 1/8|18|UNEF|2B|1 1/8-18 UNEF 2B|1.125-18 UNEF 2B|-|-|1.125|1.125|-|1.0951|1.0889|1.078|1.065|
1 1/8|18|UNEF|3A|1 1/8-18 UNEF 3A|1.125-18 UNEF 3A|0|1.125|1.125|1.1163|-|1.0889|1.0853|1.0589|-|
1 1/8|18|UNEF|3B|1 1/8-18 UNEF 3B|1.125-18 UNEF 3B|-|-|1.125|1.125|-|1.0935|1.0889|1.073|1.065|
1 1/8|20|UN|2A|1 1/8-20 UN 2A|1.125-20 UN 2A|0.0014|1.1236|1.125|1.1155|-|1.0911|1.0866|1.0641|-|
1 1/8|20|UN|2B|1 1/8-20 UN 2B|1.125-20 UN 2B|-|-|1.125|1.125|-|1.0984|1.0925|1.082|1.071|
1 1/8|20|UN|3A|1 1/8-20 UN 3A|1.125-20 UN 3A|0|1.125|1.125|1.1169|-|1.0925|1.0891|1.0655|-|
1 1/8|20|UN|3B|1 1/8-20 UN 3B|1.125-20 UN 3B|-|-|1.125|1.125|-|1.0969|1.0925|1.0787|1.071|
1 1/8|24|UNS|2A|1 1/8-24 UNS 2A|1.125-24 UNS 2A|0.0013|1.1237|1.125|1.1165|-|1.0966|1.0924|1.0742|-|
1 1/8|24|UNS|2B|1 1/8-24 UNS 2B|1.125-24 UNS 2B|-|-|1.125|1.125|-|1.1034|1.0979|1.09|1.08|
1 1/8|28|UN|2A|1 1/8-28 UN 2A|1.125-28 UN 2A|0.0012|1.1238|1.125|1.1173|-|1.1006|1.0966|1.0812|-|
1 1/8|28|UN|2B|1 1/8-28 UN 2B|1.125-28 UN 2B|-|-|1.125|1.125|-|1.107|1.1018|1.095|1.086|
1 1/8|28|UN|3A|1 1/8-28 UN 3A|1.125-28 UN 3A|0|1.125|1.125|1.1185|-|1.1018|1.0988|1.0824|-|
1 1/8|28|UN|3B|1 1/8-28 UN 3B|1.125-28 UN 3B|-|-|1.125|1.125|-|1.1057|1.1018|1.0926|1.086|
1 3/16|8|UN|2A|1 3/16-8 UN 2A|1.188-8 UN 2A|0.0021|1.1854|1.1875|1.1704|-|1.1042|1.0972|1.0366|-|
1 3/16|8|UN|2B|1 3/16-8 UN 2B|1.188-8 UN 2B|-|-|1.1875|1.1875|-|1.1154|1.1063|1.077|1.052|
1 3/16|8|UN|3A|1 3/16-8 UN 3A|1.188-8 UN 3A|0|1.1875|1.1875|1.1725|-|1.1063|1.1011|1.0387|-|
1 3/16|8|UN|3B|1 3/16-8 UN 3B|1.188-8 UN 3B|-|-|1.1875|1.1875|-|1.1131|1.1063|1.0672|1.052|
1 3/16|12|UN|2A|1 3/16-12 UN 2A|1.188-12 UN 2A|0.0017|1.1858|1.1875|1.1744|-|1.1317|1.1259|1.0866|-|
1 3/16|12|UN|2B|1 3/16-12 UN 2B|1.188-12 UN 2B|-|-|1.1875|1.1875|-|1.1409|1.1334|1.115|1.097|
1 3/16|12|UN|3A|1 3/16-12 UN 3A|1.188-12 UN 3A|0|1.1875|1.1875|1.1761|-|1.1334|1.1291|1.0883|-|
1 3/16|12|UN|3B|1 3/16-12 UN 3B|1.188-12 UN 3B|-|-|1.1875|1.1875|-|1.139|1.1334|1.1073|1.097|
1 3/16|16|UN|2A|1 3/16-16 UN 2A|1.188-16 UN 2A|0.0015|1.186|1.1875|1.1766|-|1.1454|1.1403|1.1115|-|
1 3/16|16|UN|2B|1 3/16-16 UN 2B|1.188-16 UN 2B|-|-|1.1875|1.1875|-|1.1535|1.1469|1.134|1.12|
1 3/16|16|UN|3A|1 3/16-16 UN 3A|1.188-16 UN 3A|0|1.1875|1.1875|1.1781|-|1.1469|1.1431|1.113|-|
1 3/16|16|UN|3B|1 3/16-16 UN 3B|1.188-16 UN 3B|-|-|1.1875|1.1875|-|1.1519|1.1469|1.1283|1.12|
1 3/16|18|UNEF|2A|1 3/16-18 UNEF 2A|1.188-18 UNEF 2A|0.0015|1.186|1.1875|1.1773|-|1.1499|1.145|1.1199|-|
1 3/16|18|UNEF|2B|1 3/16-18 UNEF 2B|1.188-18 UNEF 2B|-|-|1.1875|1.1875|-|1.1577|1.1514|1.14|1.127|
1 3/16|18|UNEF|3A|1 3/16-18 UNEF 3A|1.188-18 UNEF 3A|0|1.1875|1.1875|1.1788|-|1.1514|1.1478|1.1214|-|
1 3/16|18|UNEF|3B|1 3/16-18 UNEF 3B|1.188-18 UNEF 3B|-|-|1.1875|1.1875|-|1.1561|1.1514|1.1355|1.127|
1 3/16|20|UN|2A|1 3/16-20 UN 2A|1.188-20 UN 2A|0.0014|1.1861|1.1875|1.178|-|1.1536|1.1489|1.1266|-|
1 3/16|20|UN|2B|1 3/16-20 UN 2B|1.188-20 UN 2B|-|-|1.1875|1.1875|-|1.1611|1.155|1.145|1.133|
1 3/16|20|UN|3A|1 3/16-20 UN 3A|1.188-20 UN 3A|0|1.1875|1.1875|1.1794|-|1.155|1.1515|1.128|-|
1 3/16|20|UN|3B|1 3/16-20 UN 3B|1.188-20 UN 3B|-|-|1.1875|1.1875|-|1.1595|1.155|1.1412|1.133|
1 3/16|28|UN|2A|1 3/16-28 UN 2A|1.188-28 UN 2A|0.0012|1.1863|1.1875|1.1798|-|1.1631|1.159|1.1437|-|
1 3/16|28|UN|2B|1 3/16-28 UN 2B|1.188-28 UN 2B|-|-|1.1875|1.1875|-|1.1696|1.1643|1.157|1.149|
1 3/16|28|UN|3A|1 3/16-28 UN 3A|1.188-28 UN 3A|0|1.1875|1.1875|1.181|-|1.1643|1.1612|1.1449|-|
1 3/16|28|UN|3B|1 3/16-28 UN 3B|1.188-28 UN 3B|-|-|1.1875|1.1875|-|1.1683|1.1643|1.1551|1.149|
1 1/4|7|UNC|1A|1 1/4-7 UNC 1A|1.250-7 UNC 1A|0.0022|1.2478|1.25|1.2232|-|1.155|1.1439|1.0777|-|
1 1/4|7|UNC|1B|1 1/4-7 UNC 1B|1.250-7 UNC 1B|-|-|1.25|1.25|-|1.1716|1.1572|1.123|1.095|
1 1/4|7|UNC|2A|1 1/4-7 UNC 2A|1.250-7 UNC 2A|0.0022|1.2478|1.25|1.2314|1.2232|1.155|1.1476|1.0777|-|
1 1/4|7|UNC|2B|1 1/4-7 UNC 2B|1.250-7 UNC 2B|-|-|1.25|1.25|-|1.1668|1.1572|1.123|1.095|
1 1/4|7|UNC|3A|1 1/4-7 UNC 3A|1.250-7 UNC 3A|0|1.25|1.25|1.2336|-|1.1572|1.1517|1.0799|-|
1 1/4|7|UNC|3B|1 1/4-7 UNC 3B|1.250-7 UNC 3B|-|-|1.25|1.25|-|1.1644|1.1572|1.1125|1.095|
1 1/4|8|UN|2A|1 1/4-8 UN 2A|1.250-8 UN 2A|0.0021|1.2479|1.25|1.2329|1.2254|1.1667|1.1597|1.0991|-|
1 1/4|8|UN|2B|1 1/4-8 UN 2B|1.250-8 UN 2B|-|-|1.25|1.25|-|1.178|1.1688|1.14|1.115|
1 1/4|8|UN|3A|1 1/4-8 UN 3A|1.250-8 UN 3A|0|1.25|1.25|1.235|-|1.1688|1.1635|1.1012|-|
1 1/4|8|UN|3B|1 1/4-8 UN 3B|1.250-8 UN 3B|-|-|1.25|1.25|-|1.1757|1.1688|1.1297|1.115|
1 1/4|10|UNS|2A|1 1/4-10 UNS 2A|1.250-10 UNS 2A|0.0019|1.2481|1.25|1.2352|-|1.1831|1.1768|1.1291|-|
1 1/4|10|UNS|2B|1 1/4-10 UNS 2B|1.250-10 UNS 2B|-|-|1.25|1.25|-|1.1932|1.185|1.163|1.142|
1 1/4|12|UNF|1A|1 1/4-12 UNF 1A|1.250-12 UNF 1A|0.0018|1.2482|1.25|1.231|-|1.1941|1.1849|1.149|-|
1 1/4|12|UNF|1B|1 1/4-12 UNF 1B|1.250-12 UNF 1B|-|-|1.25|1.25|-|1.2079|1.1959|1.178|1.16|
1 1/4|12|UNF|2A|1 1/4-12 UNF 2A|1.250-12 UNF 2A|0.0018|1.2482|1.25|1.2368|-|1.1941|1.1879|1.149|-|
1 1/4|12|UNF|2B|1 1/4-12 UNF 2B|1.250-12 UNF 2B|-|-|1.25|1.25|-|1.2039|1.1959|1.178|1.16|
1 1/4|12|UNF|3A|1 1/4-12 UNF 3A|1.250-12 UNF 3A|0|1.25|1.25|1.2386|-|1.1959|1.1913|1.1508|-|
1 1/4|12|UNF|3B|1 1/4-12 UNF 3B|1.250-12 UNF 3B|-|-|1.25|1.25|-|1.2019|1.1959|1.1698|1.16|
1 1/4|14|UNS|2A|1 1/4-14 UNS 2A|1.250-14 UNS 2A|0.0016|1.2484|1.25|1.2381|-|1.202|1.1966|1.1634|-|
1 1/4|14|UNS|2B|1 1/4-14 UNS 2B|1.250-14 UNS 2B|-|-|1.25|1.25|-|1.2106|1.2036|1.188|1.173|
1 1/4|16|UN|2A|1 1/4-16 UN 2A|1.250-16 UN 2A|0.0015|1.2485|1.25|1.2391|-|1.2079|1.2028|1.174|-|
1 1/4|16|UN|2B|1 1/4-16 UN 2B|1.250-16 UN 2B|-|-|1.25|1.25|-|1.216|1.2094|1.196|1.182|
1 1/4|16|UN|3A|1 1/4-16 UN 3A|1.250-16 UN 3A|0|1.25|1.25|1.2406|-|1.2094|1.2056|1.1755|-|
1 1/4|16|UN|3B|1 1/4-16 UN 3B|1.250-16 UN 3B|-|-|1.25|1.25|-|1.2144|1.2094|1.1908|1.182|
1 1/4|18|UNEF|2A|1 1/4-18 UNEF 2A|1.250-18 UNEF 2A|0.0015|1.2485|1.25|1.2398|-|1.2124|1.2075|1.1824|-|
1 1/4|18|UNEF|2B|1 1/4-18 UNEF 2B|1.250-18 UNEF 2B|-|-|1.25|1.25|-|1.2202|1.2139|1.203|1.19|
1 1/4|18|UNEF|3A|1 1/4-18 UNEF 3A|1.250-18 UNEF 3A|0|1.25|1.25|1.2413|-|1.2139|1.2103|1.1839|-|
1 1/4|18|UNEF|3B|1 1/4-18 UNEF 3B|1.250-18 UNEF 3B|-|-|1.25|1.25|-|1.2186|1.2139|1.198|1.19|
1 1/4|20|UN|2A|1 1/4-20 UN 2A|1.250-20 UN 2A|0.0014|1.2486|1.25|1.2405|-|1.2161|1.2114|1.1891|-|
1 1/4|20|UN|2B|1 1/4-20 UN 2B|1.250-20 UN 2B|-|-|1.25|1.25|-|1.2236|1.2175|1.207|1.196|
1 1/4|20|UN|3A|1 1/4-20 UN 3A|1.250-20 UN 3A|0|1.25|1.25|1.2419|-|1.2175|1.214|1.1905|-|
1 1/4|20|UN|3B|1 1/4-20 UN 3B|1.250-20 UN 3B|-|-|1.25|1.25|-|1.222|1.2175|1.2037|1.196|
1 1/4|24|UNS|2A|1 1/4-24 UNS 2A|1.250-24 UNS 2A|0.0013|1.2487|1.25|1.2415|-|1.2216|1.2173|1.1991|-|
1 1/4|24|UNS|2B|1 1/4-24 UNS 2B|1.250-24 UNS 2B|-|-|1.25|1.25|-|1.2285|1.2229|1.215|1.205|
1 1/4|28|UN|2A|1 1/4-28 UN 2A|1.250-28 UN 2A|0.0012|1.2488|1.25|1.2423|-|1.2256|1.2215|1.2062|-|
1 1/4|28|UN|2B|1 1/4-28 UN 2B|1.250-28 UN 2B|-|-|1.25|1.25|-|1.2321|1.2268|1.22|1.211|
1 1/4|28|UN|3A|1 1/4-28 UN 3A|1.250-28 UN 3A|0|1.25|1.25|1.2435|-|1.2268|1.2237|1.2074|-|
1 1/4|28|UN|3B|1 1/4-28 UN 3B|1.250-28 UN 3B|-|-|1.25|1.25|-|1.2308|1.2268|1.2176|1.211|
1 5/16|8|UN|2A|1 5/16-8 UN 2A|1.313-8 UN 2A|0.0021|1.3104|1.3125|1.2954|-|1.2292|1.2221|1.1616|-|
1 5/16|8|UN|2B|1 5/16-8 UN 2B|1.313-8 UN 2B|-|-|1.3125|1.3125|-|1.2405|1.2313|1.202|1.177|
1 5/16|8|UN|3A|1 5/16-8 UN 3A|1.313-8 UN 3A|0|1.3125|1.3125|1.2975|-|1.2313|1.226|1.1637|-|
1 5/16|8|UN|3B|1 5/16-8 UN 3B|1.313-8 UN 3B|-|-|1.3125|1.3125|-|1.2382|1.2313|1.1922|1.177|
1 5/16|12|UN|2A|1 5/16-12 UN 2A|1.313-12 UN 2A|0.0017|1.3108|1.3125|1.2994|-|1.2567|1.2509|1.2116|-|
1 5/16|12|UN|2B|1 5/16-12 UN 2B|1.313-12 UN 2B|-|-|1.3125|1.3125|-|1.2659|1.2584|1.24|1.222|
1 5/16|12|UN|3A|1 5/16-12 UN 3A|1.313-12 UN 3A|0|1.3125|1.3125|1.3011|-|1.2584|1.2541|1.2133|-|
1 5/16|12|UN|3B|1 5/16-12 UN 3B|1.313-12 UN 3B|-|-|1.3125|1.3125|-|1.264|1.2584|1.2323|1.222|
1 5/16|16|UN|2A|1 5/16-16 UN 2A|1.313-16 UN 2A|0.0015|1.311|1.3125|1.3016|-|1.2704|1.2653|1.2365|-|
1 5/16|16|UN|2B|1 5/16-16 UN 2B|1.313-16 UN 2B|-|-|1.3125|1.3125|-|1.2785|1.2719|1.259|1.245|
1 5/16|16|UN|3A|1 5/16-16 UN 3A|1.313-16 UN 3A|0|1.3125|1.3125|1.3031|-|1.2719|1.2681|1.238|-|
1 5/16|16|UN|3B|1 5/16-16 UN 3B|1.313-16 UN 3B|-|-|1.3125|1.3125|-|1.2769|1.2719|1.2533|1.245|
1 5/16|18|UNEF|2A|1 5/16-18 UNEF 2A|1.313-18 UNEF 2A|0.0015|1.311|1.3125|1.3023|-|1.2749|1.27|1.2449|-|
1 5/16|18|UNEF|2B|1 5/16-18 UNEF 2B|1.313-18 UNEF 2B|-|-|1.3125|1.3125|-|1.2827|1.2764|1.265|1.252|
1 5/16|18|UNEF|3A|1 5/16-18 UNEF 3A|1.313-18 UNEF 3A|0|1.3125|1.3125|1.3038|-|1.2764|1.2728|1.2464|-|
1 5/16|18|UNEF|3B|1 5/16-18 UNEF 3B|1.313-18 UNEF 3B|-|-|1.3125|1.3125|-|1.2811|1.2764|1.2605|1.252|
1 5/16|20|UN|2A|1 5/16-20 UN 2A|1.313-20 UN 2A|0.0014|1.3111|1.3125|1.303|-|1.2786|1.2739|1.2516|-|
1 5/16|20|UN|2B|1 5/16-20 UN 2B|1.313-20 UN 2B|-|-|1.3125|1.3125|-|1.2861|1.28|1.27|1.258|
1 5/16|20|UN|3A|1 5/16-20 UN 3A|1.313-20 UN 3A|0|1.3125|1.3125|1.3044|-|1.28|1.2765|1.253|-|
1 5/16|20|UN|3B|1 5/16-20 UN 3B|1.313-20 UN 3B|-|-|1.3125|1.3125|-|1.2845|1.28|1.2662|1.258|
1 5/16|28|UN|2A|1 5/16-28 UN 2A|1.313-28 UN 2A|0.0012|1.3113|1.3125|1.3048|-|1.2881|1.284|1.2687|-|
1 5/16|28|UN|2B|1 5/16-28 UN 2B|1.313-28 UN 2B|-|-|1.3125|1.3125|-|1.2946|1.2893|1.282|1.274|
1 5/16|28|UN|3A|1 5/16-28 UN 3A|1.313-28 UN 3A|0|1.3125|1.3125|1.306|-|1.2893|1.2862|1.2699|-|
1 5/16|28|UN|3B|1 5/16-28 UN 3B|1.313-28 UN 3B|-|-|1.3125|1.3125|-|1.2933|1.2893|1.2801|1.274|
1 3/8|6|UNC|1A|1 3/8-6 UNC 1A|1.375-6 UNC 1A|0.0024|1.3726|1.375|1.3453|-|1.2643|1.2523|1.1742|-|
1 3/8|6|UNC|1B|1 3/8-6 UNC 1B|1.375-6 UNC 1B|-|-|1.375|1.375|-|1.2822|1.2667|1.225|1.195|
1 3/8|6|UNC|2A|1 3/8-6 UNC 2A|1.375-6 UNC 2A|0.0024|1.3726|1.375|1.3544|1.3453|1.2643|1.2563|1.1742|-|
1 3/8|6|UNC|2B|1 3/8-6 UNC 2B|1.375-6 UNC 2B|-|-|1.375|1.375|-|1.2771|1.2667|1.225|1.195|
1 3/8|6|UNC|3A|1 3/8-6 UNC 3A|1.375-6 UNC 3A|0|1.375|1.375|1.3568|-|1.2667|1.2607|1.1766|-|
1 3/8|6|UNC|3B|1 3/8-6 UNC 3B|1.375-6 UNC 3B|-|-|1.375|1.375|-|1.2745|1.2667|1.2146|1.195|
1 3/8|8|UN|2A|1 3/8-8 UN 2A|1.375-8 UN 2A|0.0022|1.3728|1.375|1.3578|1.3503|1.2916|1.2844|1.224|-|
1 3/8|8|UN|2B|1 3/8-8 UN 2B|1.375-8 UN 2B|-|-|1.375|1.375|-|1.3031|1.2938|1.265|1.24|
1 3/8|8|UN|3A|1 3/8-8 UN 3A|1.375-8 UN 3A|0|1.375|1.375|1.36|-|1.2938|1.2884|1.2262|-|
1 3/8|8|UN|3B|1 3/8-8 UN 3B|1.375-8 UN 3B|-|-|1.375|1.375|-|1.3008|1.2938|1.2547|1.24|
1 3/8|10|UNS|2A|1 3/8-10 UNS 2A|1.375-10 UNS 2A|0.0019|1.3731|1.375|1.3602|-|1.3081|1.3018|1.2541|-|
1 3/8|10|UNS|2B|1 3/8-10 UNS 2B|1.375-10 UNS 2B|-|-|1.375|1.375|-|1.3182|1.31|1.288|1.267|
1 3/8|12|UNF|1A|1 3/8-12 UNF 1A|1.375-12 UNF 1A|0.0019|1.3731|1.375|1.3559|-|1.319|1.3096|1.2739|-|
1 3/8|12|UNF|1B|1 3/8-12 UNF 1B|1.375-12 UNF 1B|-|-|1.375|1.375|-|1.3332|1.3209|1.303|1.285|
1 3/8|12|UNF|2A|1 3/8-12 UNF 2A|1.375-12 UNF 2A|0.0019|1.3731|1.375|1.3617|-|1.319|1.3127|1.2739|-|
1 3/8|12|UNF|2B|1 3/8-12 UNF 2B|1.375-12 UNF 2B|-|-|1.375|1.375|-|1.3291|1.3209|1.303|1.285|
1 3/8|12|UNF|3A|1 3/8-12 UNF 3A|1.375-12 UNF 3A|0|1.375|1.375|1.3636|-|1.3209|1.3162|1.2758|-|
1 3/8|12|UNF|3B|1 3/8-12 UNF 3B|1.375-12 UNF 3B|-|-|1.375|1.375|-|1.327|1.3209|1.2948|1.285|
1 3/8|14|UNS|2A|1 3/8-14 UNS 2A|1.375-14 UNS 2A|0.0016|1.3734|1.375|1.3631|-|1.327|1.3216|1.2884|-|
1 3/8|14|UNS|2B|1 3/8-14 UNS 2B|1.375-14 UNS 2B|-|-|1.375|1.375|-|1.3356|1.3286|1.314|1.298|
1 3/8|16|UN|2A|1 3/8-16 UN 2A|1.375-16 UN 2A|0.0015|1.3735|1.375|1.3641|-|1.3329|1.3278|1.299|-|
1 3/8|16|UN|2B|1 3/8-16 UN 2B|1.375-16 UN 2B|-|-|1.375|1.375|-|1.341|1.3344|1.321|1.307|
1 3/8|16|UN|3A|1 3/8-16 UN 3A|1.375-16 UN 3A|0|1.375|1.375|1.3656|-|1.3344|1.3306|1.3005|-|
1 3/8|16|UN|3B|1 3/8-16 UN 3B|1.375-16 UN 3B|-|-|1.375|1.375|-|1.3394|1.3344|1.3158|1.307|
1 3/8|18|UNEF|2A|1 3/8-18 UNEF 2A|1.375-18 UNEF 2A|0.0015|1.3735|1.375|1.3648|-|1.3374|1.3325|1.3074|-|
1 3/8|18|UNEF|2B|1 3/8-18 UNEF 2B|1.375-18 UNEF 2B|-|-|1.375|1.375|-|1.3452|1.3389|1.328|1.315|
1 3/8|18|UNEF|3A|1 3/8-18 UNEF 3A|1.375-18 UNEF 3A|0|1.375|1.375|1.3663|-|1.3389|1.3353|1.3089|-|
1 3/8|18|UNEF|3B|1 3/8-18 UNEF 3B|1.375-18 UNEF 3B|-|-|1.375|1.375|-|1.3436|1.3389|1.323|1.315|
1 3/8|20|UN|2A|1 3/8-20 UN 2A|1.375-20 UN 2A|0.0014|1.3736|1.375|1.3655|-|1.3411|1.3364|1.3141|-|
1 3/8|20|UN|2B|1 3/8-20 UN 2B|1.375-20 UN 2B|-|-|1.375|1.375|-|1.3486|1.3425|1.332|1.321|
1 3/8|20|UN|3A|1 3/8-20 UN 3A|1.375-20 UN 3A|0|1.375|1.375|1.3669|-|1.3425|1.339|1.3155|-|
1 3/8|20|UN|3B|1 3/8-20 UN 3B|1.375-20 UN 3B|-|-|1.375|1.375|-|1.347|1.3425|1.3287|1.321|
1 3/8|24|UNS|2A|1 3/8-24 UNS 2A|1.375-24 UNS 2A|0.0013|1.3737|1.375|1.3665|-|1.3466|1.3423|1.3241|-|
1 3/8|24|UNS|2B|1 3/8-24 UNS 2B|1.375-24 UNS 2B|-|-|1.375|1.375|-|1.3535|1.3479|1.34|1.33|
1 3/8|28|UN|2A|1 3/8-28 UN 2A|1.375-28 UN 2A|0.0012|1.3738|1.375|1.3673|-|1.3506|1.3465|1.3312|-|
1 3/8|28|UN|2B|1 3/8-28 UN 2B|1.375-28 UN 2B|-|-|1.375|1.375|-|1.3571|1.3518|1.345|1.336|
1 3/8|28|UN|3A|1 3/8-28 UN 3A|1.375-28 UN 3A|0|1.375|1.375|1.3685|-|1.3518|1.3487|1.3324|-|
1 3/8|28|UN|3B|1 3/8-28 UN 3B|1.375-28 UN 3B|-|-|1.375|1.375|-|1.3558|1.3518|1.3426|1.336|
1 7/16|6|UN|2A|1 7/16-6 UN 2A|1.438-6 UN 2A|0.0024|1.4351|1.4375|1.4169|-|1.3268|1.3188|1.2367|-|
1 7/16|6|UN|2B|1 7/16-6 UN 2B|1.438-6 UN 2B|-|-|1.4375|1.4375|-|1.3396|1.3292|1.288|1.257|
1 7/16|6|UN|3A|1 7/16-6 UN 3A|1.438-6 UN 3A|0|1.4375|1.4375|1.4193|-|1.3292|1.3232|1.2391|-|
1 7/16|6|UN|3B|1 7/16-6 UN 3B|1.438-6 UN 3B|-|-|1.4375|1.4375|-|1.337|1.3292|1.2771|1.257|
1 7/16|8|UN|2A|1 7/16-8 UN 2A|1.438-8 UN 2A|0.0022|1.4353|1.4375|1.4203|-|1.3541|1.3469|1.2865|-|
1 7/16|8|UN|2B|1 7/16-8 UN 2B|1.438-8 UN 2B|-|-|1.4375|1.4375|-|1.3657|1.3563|1.327|1.302|
1 7/16|8|UN|3A|1 7/16-8 UN 3A|1.438-8 UN 3A|0|1.4375|1.4375|1.4225|-|1.3563|1.3509|1.2887|-|
1 7/16|8|UN|3B|1 7/16-8 UN 3B|1.438-8 UN 3B|-|-|1.4375|1.4375|-|1.3634|1.3563|1.3172|1.302|
1 7/16|12|UN|2A|1 7/16-12 UN 2A|1.438-12 UN 2A|0.0018|1.4357|1.4375|1.4243|-|1.3816|1.3757|1.3365|-|
1 7/16|12|UN|2B|1 7/16-12 UN 2B|1.438-12 UN 2B|-|-|1.4375|1.4375|-|1.391|1.3834|1.365|1.347|
1 7/16|12|UN|3A|1 7/16-12 UN 3A|1.438-12 UN 3A|0|1.4375|1.4375|1.4261|-|1.3834|1.379|1.3383|-|
1 7/16|12|UN|3B|1 7/16-12 UN 3B|1.438-12 UN 3B|-|-|1.4375|1.4375|-|1.3891|1.3834|1.3573|1.347|
1 7/16|16|UN|2A|1 7/16-16 UN 2A|1.438-16 UN 2A|0.0016|1.4359|1.4375|1.4265|-|1.3953|1.3901|1.3614|-|
1 7/16|16|UN|2B|1 7/16-16 UN 2B|1.438-16 UN 2B|-|-|1.4375|1.4375|-|1.4037|1.3969|1.384|1.37|
1 7/16|16|UN|3A|1 7/16-16 UN 3A|1.438-16 UN 3A|0|1.4375|1.4375|1.4281|-|1.3969|1.393|1.363|-|
1 7/16|16|UN|3B|1 7/16-16 UN 3B|1.438-16 UN 3B|-|-|1.4375|1.4375|-|1.402|1.3969|1.3783|1.37|
1 7/16|18|UNEF|2A|1 7/16-18 UNEF 2A|1.438-18 UNEF 2A|0.0015|1.436|1.4375|1.4273|-|1.3999|1.3949|1.3699|-|
1 7/16|18|UNEF|2B|1 7/16-18 UNEF 2B|1.438-18 UNEF 2B|-|-|1.4375|1.4375|-|1.4079|1.4014|1.39|1.377|
1 7/16|18|UNEF|3A|1 7/16-18 UNEF 3A|1.438-18 UNEF 3A|0|1.4375|1.4375|1.4288|-|1.4014|1.3977|1.3714|-|
1 7/16|18|UNEF|3B|1 7/16-18 UNEF 3B|1.438-18 UNEF 3B|-|-|1.4375|1.4375|-|1.4062|1.4014|1.3855|1.377|
1 7/16|20|UN|2A|1 7/16-20 UN 2A|1.438-20 UN 2A|0.0014|1.4361|1.4375|1.428|-|1.4036|1.3988|1.3766|-|
1 7/16|20|UN|2B|1 7/16-20 UN 2B|1.438-20 UN 2B|-|-|1.4375|1.4375|-|1.4112|1.405|1.395|1.383|
1 7/16|20|UN|3A|1 7/16-20 UN 3A|1.438-20 UN 3A|0|1.4375|1.4375|1.4294|-|1.405|1.4014|1.378|-|
1 7/16|20|UN|3B|1 7/16-20 UN 3B|1.438-20 UN 3B|-|-|1.4375|1.4375|-|1.4096|1.405|1.3912|1.383|
1 7/16|28|UN|2A|1 7/16-28 UN 2A|1.438-28 UN 2A|0.0013|1.4362|1.4375|1.4297|-|1.413|1.4088|1.3936|-|
1 7/16|28|UN|2B|1 7/16-28 UN 2B|1.438-28 UN 2B|-|-|1.4375|1.4375|-|1.4198|1.4143|1.407|1.399|
1 7/16|28|UN|3A|1 7/16-28 UN 3A|1.438-28 UN 3A|0|1.4375|1.4375|1.431|-|1.4143|1.4112|1.3949|-|
1 7/16|28|UN|3B|1 7/16-28 UN 3B|1.438-28 UN 3B|-|-|1.4375|1.4375|-|1.4184|1.4143|1.4051|1.399|
1 1/2|6|UNC|1A|1 1/2-6 UNC 1A|1.500-6 UNC 1A|0.0024|1.4976|1.5|1.4703|-|1.3893|1.3772|1.2992|-|
1 1/2|6|UNC|1B|1 1/2-6 UNC 1B|1.500-6 UNC 1B|-|-|1.5|1.5|-|1.4075|1.3917|1.35|1.32|
1 1/2|6|UNC|2A|1 1/2-6 UNC 2A|1.500-6 UNC 2A|0.0024|1.4976|1.5|1.4794|1.4703|1.3893|1.3812|1.2992|-|
1 1/2|6|UNC|2B|1 1/2-6 UNC 2B|1.500-6 UNC 2B|-|-|1.5|1.5|-|1.4022|1.3917|1.35|1.32|
1 1/2|6|UNC|3A|1 1/2-6 UNC 3A|1.500-6 UNC 3A|0|1.5|1.5|1.4818|-|1.3917|1.3856|1.3016|-|
1 1/2|6|UNC|3B|1 1/2-6 UNC 3B|1.500-6 UNC 3B|-|-|1.5|1.5|-|1.3996|1.3917|1.3396|1.32|
1 1/2|8|UN|2A|1 1/2-8 UN 2A|1.500-8 UN 2A|0.0022|1.4978|1.5|1.4828|1.4753|1.4166|1.4093|1.349|-|
1 1/2|8|UN|2B|1 1/2-8 UN 2B|1.500-8 UN 2B|-|-|1.5|1.5|-|1.4283|1.4188|1.39|1.365|
1 1/2|8|UN|3A|1 1/2-8 UN 3A|1.500-8 UN 3A|0|1.5|1.5|1.485|-|1.4188|1.4133|1.3512|-|
1 1/2|8|UN|3B|1 1/2-8 UN 3B|1.500-8 UN 3B|-|-|1.5|1.5|-|1.4259|1.4188|1.3797|1.365|
1 1/2|10|UNS|2A|1 1/2-10 UNS 2A|1.500-10 UNS 2A|0.0019|1.4981|1.5|1.4852|-|1.4331|1.4267|1.3791|-|
1 1/2|10|UNS|2B|1 1/2-10 UNS 2B|1.500-10 UNS 2B|-|-|1.5|1.5|-|1.4433|1.435|1.413|1.392|
1 1/2|12|UNF|1A|1 1/2-12 UNF 1A|1.500-12 UNF 1A|0.0019|1.4981|1.5|1.4809|-|1.444|1.4344|1.3989|-|
1 1/2|12|UNF|1B|1 1/2-12 UNF 1B|1.500-12 UNF 1B|-|-|1.5|1.5|-|1.4584|1.4459|1.428|1.41|
1 1/2|12|UNF|2A|1 1/2-12 UNF 2A|1.500-12 UNF 2A|0.0019|1.4981|1.5|1.4867|-|1.444|1.4376|1.3989|-|
1 1/2|12|UNF|2B|1 1/2-12 UNF 2B|1.500-12 UNF 2B|-|-|1.5|1.5|-|1.4542|1.4459|1.428|1.41|
1 1/2|12|UNF|3A|1 1/2-12 UNF 3A|1.500-12 UNF 3A|0|1.5|1.5|1.4886|-|1.4459|1.4411|1.4008|-|
1 1/2|12|UNF|3B|1 1/2-12 UNF 3B|1.500-12 UNF 3B|-|-|1.5|1.5|-|1.4522|1.4459|1.4198|1.41|
1 1/2|14|UNS|2A|1 1/2-14 UNS 2A|1.500-14 UNS 2A|0.0017|1.4983|1.5|1.488|-|1.4519|1.4464|1.4133|-|
1 1/2|14|UNS|2B|1 1/2-14 UNS 2B|1.500-14 UNS 2B|-|-|1.5|1.5|-|1.4608|1.4536|1.438|1.423|
1 1/2|16|UN|2A|1 1/2-16 UN 2A|1.500-16 UN 2A|0.0016|1.4984|1.5|1.489|-|1.4578|1.4526|1.4239|-|
1 1/2|16|UN|2B|1 1/2-16 UN 2B|1.500-16 UN 2B|-|-|1.5|1.5|-|1.4662|1.4594|1.446|1.432|
1 1/2|16|UN|3A|1 1/2-16 UN 3A|1.500-16 UN 3A|0|1.5|1.5|1.4906|-|1.4594|1.4555|1.4255|-|
1 1/2|16|UN|3B|1 1/2-16 UN 3B|1.500-16 UN 3B|-|-|1.5|1.5|-|1.4645|1.4594|1.4408|1.432|
1 1/2|18|UNEF|2A|1 1/2-18 UNEF 2A|1.500-18 UNEF 2A|0.0015|1.4985|1.5|1.4898|-|1.4624|1.4574|1.4324|-|
1 1/2|18|UNEF|2B|1 1/2-18 UNEF 2B|1.500-18 UNEF 2B|-|-|1.5|1.5|-|1.4704|1.4639|1.452|1.44|
1 1/2|18|UNEF|3A|1 1/2-18 UNEF 3A|1.500-18 UNEF 3A|0|1.5|1.5|1.4913|-|1.4639|1.4602|1.4339|-|
1 1/2|18|UNEF|3B|1 1/2-18 UNEF 3B|1.500-18 UNEF 3B|-|-|1.5|1.5|-|1.4687|1.4639|1.448|1.44|
1 1/2|20|UN|2A|1 1/2-20 UN 2A|1.500-20 UN 2A|0.0014|1.4986|1.5|1.4905|-|1.4661|1.4613|1.4391|-|
1 1/2|20|UN|2B|1 1/2-20 UN 2B|1.500-20 UN 2B|-|-|1.5|1.5|-|1.4737|1.4675|1.457|1.446|
1 1/2|20|UN|3A|1 1/2-20 UN 3A|1.500-20 UN 3A|0|1.5|1.5|1.4919|-|1.4675|1.4639|1.4405|-|
1 1/2|20|UN|3B|1 1/2-20 UN 3B|1.500-20 UN 3B|-|-|1.5|1.5|-|1.4721|1.4675|1.4537|1.446|
1 1/2|24|UNS|2A|1 1/2-24 UNS 2A|1.500-24 UNS 2A|0.0013|1.4987|1.5|1.4915|-|1.4716|1.4672|1.4491|-|
1 1/2|24|UNS|2B|1 1/2-24 UNS 2B|1.500-24 UNS 2B|-|-|1.5|1.5|-|1.4787|1.4729|1.465|1.455|
1 1/2|28|UN|2A|1 1/2-28 UN 2A|1.500-28 UN 2A|0.0013|1.4987|1.5|1.4922|-|1.4755|1.4713|1.4561|-|
1 1/2|28|UN|2B|1 1/2-28 UN 2B|1.500-28 UN 2B|-|-|1.5|1.5|-|1.4823|1.4768|1.47|1.461|
1 1/2|28|UN|3A|1 1/2-28 UN 3A|1.500-28 UN 3A|0|1.5|1.5|1.4935|-|1.4768|1.4737|1.4574|-|
1 1/2|28|UN|3B|1 1/2-28 UN 3B|1.500-28 UN 3B|-|-|1.5|1.5|-|1.4809|1.4768|1.4676|1.461|
1 9/16|6|UN|2A|1 9/16-6 UN 2A|1.563-6 UN 2A|0.0024|1.5601|1.5625|1.5419|-|1.4518|1.4436|1.3617|-|
1 9/16|6|UN|2B|1 9/16-6 UN 2B|1.563-6 UN 2B|-|-|1.5625|1.5625|-|1.4648|1.4542|1.413|1.382|
1 9/16|6|UN|3A|1 9/16-6 UN 3A|1.563-6 UN 3A|0|1.5625|1.5625|1.5443|-|1.4542|1.4481|1.3641|-|
1 9/16|6|UN|3B|1 9/16-6 UN 3B|1.563-6 UN 3B|-|-|1.5625|1.5625|-|1.4622|1.4542|1.4021|1.382|
1 9/16|8|UN|2A|1 9/16-8 UN 2A|1.563-8 UN 2A|0.0022|1.5603|1.5625|1.5453|-|1.4791|1.4717|1.4115|-|
1 9/16|8|UN|2B|1 9/16-8 UN 2B|1.563-8 UN 2B|-|-|1.5625|1.5625|-|1.4909|1.4813|1.452|1.427|
1 9/16|8|UN|3A|1 9/16-8 UN 3A|1.563-8 UN 3A|0|1.5625|1.5625|1.5475|-|1.4813|1.4758|1.4137|-|
1 9/16|8|UN|3B|1 9/16-8 UN 3B|1.563-8 UN 3B|-|-|1.5625|1.5625|-|1.4885|1.4813|1.4422|1.427|
1 9/16|12|UN|2A|1 9/16-12 UN 2A|1.563-12 UN 2A|0.0018|1.5607|1.5625|1.5493|-|1.5066|1.5007|1.4615|-|
1 9/16|12|UN|2B|1 9/16-12 UN 2B|1.563-12 UN 2B|-|-|1.5625|1.5625|-|1.516|1.5084|1.49|1.472|
1 9/16|12|UN|3A|1 9/16-12 UN 3A|1.563-12 UN 3A|0|1.5625|1.5625|1.5511|-|1.5084|1.504|1.4633|-|
1 9/16|12|UN|3B|1 9/16-12 UN 3B|1.563-12 UN 3B|-|-|1.5625|1.5625|-|1.5141|1.5084|1.4823|1.472|
1 9/16|16|UN|2A|1 9/16-16 UN 2A|1.563-16 UN 2A|0.0016|1.5609|1.5625|1.5515|-|1.5203|1.5151|1.4864|-|
1 9/16|16|UN|2B|1 9/16-16 UN 2B|1.563-16 UN 2B|-|-|1.5625|1.5625|-|1.5287|1.5219|1.509|1.495|
1 9/16|16|UN|3A|1 9/16-16 UN 3A|1.563-16 UN 3A|0|1.5625|1.5625|1.5531|-|1.5219|1.518|1.488|-|
1 9/16|16|UN|3B|1 9/16-16 UN 3B|1.563-16 UN 3B|-|-|1.5625|1.5625|-|1.527|1.5219|1.5033|1.495|
1 9/16|18|UNEF|2A|1 9/16-18 UNEF 2A|1.563-18 UNEF 2A|0.0015|1.561|1.5625|1.5523|-|1.5249|1.5199|1.4949|-|
1 9/16|18|UNEF|2B|1 9/16-18 UNEF 2B|1.563-18 UNEF 2B|-|-|1.5625|1.5625|-|1.5329|1.5264|1.515|1.502|
1 9/16|18|UNEF|3A|1 9/16-18 UNEF 3A|1.563-18 UNEF 3A|0|1.5625|1.5625|1.5538|-|1.5264|1.5227|1.4964|-|
1 9/16|18|UNEF|3B|1 9/16-18 UNEF 3B|1.563-18 UNEF 3B|-|-|1.5625|1.5625|-|1.5312|1.5264|1.5105|1.502|
1 9/16|20|UN|2A|1 9/16-20 UN 2A|1.563-20 UN 2A|0.0014|1.5611|1.5625|1.553|-|1.5286|1.5238|1.5016|-|
1 9/16|20|UN|2B|1 9/16-20 UN 2B|1.563-20 UN 2B|-|-|1.5625|1.5625|-|1.5362|1.53|1.52|1.508|
1 9/16|20|UN|3A|1 9/16-20 UN 3A|1.563-20 UN 3A|0|1.5625|1.5625|1.5544|-|1.53|1.5264|1.503|-|
1 9/16|20|UN|3B|1 9/16-20 UN 3B|1.563-20 UN 3B|-|-|1.5625|1.5625|-|1.5346|1.53|1.5162|1.508|
1 5/8|6|UN|2A|1 5/8-6 UN 2A|1.625-6 UN 2A|0.0025|1.6225|1.625|1.6043|-|1.5142|1.506|1.4246|-|
1 5/8|6|UN|2B|1 5/8-6 UN 2B|1.625-6 UN 2B|-|-|1.625|1.625|-|1.5274|1.5167|1.475|1.445|
1 5/8|6|UN|3A|1 5/8-6 UN 3A|1.625-6 UN 3A|0|1.625|1.625|1.6068|-|1.5167|1.5105|1.4271|-|
1 5/8|6|UN|3B|1 5/8-6 UN 3B|1.625-6 UN 3B|-|-|1.625|1.625|-|1.5247|1.5167|1.4646|1.445|
1 5/8|8|UN|2A|1 5/8-8 UN 2A|1.625-8 UN 2A|0.0022|1.6228|1.625|1.6078|1.6003|1.5416|1.5342|1.4784|-|
1 5/8|8|UN|2B|1 5/8-8 UN 2B|1.625-8 UN 2B|-|-|1.625|1.625|-|1.5535|1.5438|1.515|1.49|
1 5/8|8|UN|3A|1 5/8-8 UN 3A|1.625-8 UN 3A|0|1.625|1.625|1.61|-|1.5438|1.5382|1.4806|-|
1 5/8|8|UN|3B|1 5/8-8 UN 3B|1.625-8 UN 3B|-|-|1.625|1.625|-|1.551|1.5438|1.5047|1.49|
1 5/8|10|UNS|2A|1 5/8-10 UNS 2A|1.625-10 UNS 2A|0.0019|1.6231|1.625|1.6102|-|1.5581|1.5517|1.5041|-|
1 5/8|10|UNS|2B|1 5/8-10 UNS 2B|1.625-10 UNS 2B|-|-|1.625|1.625|-|1.5683|1.56|1.538|1.517|
1 5/8|12|UN|2A|1 5/8-12 UN 2A|1.625-12 UN 2A|0.0018|1.6232|1.625|1.6118|-|1.5691|1.5632|1.524|-|
1 5/8|12|UN|2B|1 5/8-12 UN 2B|1.625-12 UN 2B|-|-|1.625|1.625|-|1.5785|1.5709|1.553|1.535|
1 5/8|12|UN|3A|1 5/8-12 UN 3A|1.625-12 UN 3A|0|1.625|1.625|1.6136|-|1.5709|1.5665|1.5258|-|
1 5/8|12|UN|3B|1 5/8-12 UN 3B|1.625-12 UN 3B|-|-|1.625|1.625|-|1.5766|1.5709|1.5448|1.535|
1 5/8|14|UNS|2A|1 5/8-14 UNS 2A|1.625-14 UNS 2A|0.0017|1.6233|1.625|1.613|-|1.5769|1.5714|1.5383|-|
1 5/8|14|UNS|2B|1 5/8-14 UNS 2B|1.625-14 UNS 2B|-|-|1.625|1.625|-|1.5858|1.5786|1.564|1.548|
1 5/8|16|UN|2A|1 5/8-16 UN 2A|1.625-16 UN 2A|0.0016|1.6234|1.625|1.614|-|1.5828|1.5776|1.5489|-|
1 5/8|16|UN|2B|1 5/8-16 UN 2B|1.625-16 UN 2B|-|-|1.625|1.625|-|1.5912|1.5844|1.571|1.557|
1 5/8|16|UN|3A|1 5/8-16 UN 3A|1.625-16 UN 3A|0|1.625|1.625|1.6156|-|1.5844|1.5805|1.5505|-|
1 5/8|16|UN|3B|1 5/8-16 UN 3B|1.625-16 UN 3B|-|-|1.625|1.625|-|1.5895|1.5844|1.5658|1.557|
1 5/8|18|UNEF|2A|1 5/8-18 UNEF 2A|1.625-18 UNEF 2A|0.0015|1.6235|1.625|1.6148|-|1.5874|1.5824|1.5574|-|
1 5/8|18|UNEF|2B|1 5/8-18 UNEF 2B|1.625-18 UNEF 2B|-|-|1.625|1.625|-|1.5954|1.5889|1.578|1.565|
1 5/8|18|UNEF|3A|1 5/8-18 UNEF 3A|1.625-18 UNEF 3A|0|1.625|1.625|1.6163|-|1.5889|1.5852|1.5589|-|
1 5/8|18|UNEF|3B|1 5/8-18 UNEF 3B|1.625-18 UNEF 3B|-|-|1.625|1.625|-|1.5937|1.5889|1.573|1.565|
1 5/8|20|UN|2A|1 5/8-20 UN 2A|1.625-20 UN 2A|0.0014|1.6236|1.625|1.6155|-|1.5911|1.5863|1.5641|-|
1 5/8|20|UN|2B|1 5/8-20 UN 2B|1.625-20 UN 2B|-|-|1.625|1.625|-|1.5987|1.5925|1.582|1.571|
1 5/8|20|UN|3A|1 5/8-20 UN 3A|1.625-20 UN 3A|0|1.625|1.625|1.6169|-|1.5925|1.5889|1.5655|-|
1 5/8|20|UN|3B|1 5/8-20 UN 3B|1.625-20 UN 3B|-|-|1.625|1.625|-|1.5971|1.5925|1.5787|1.571|
1 5/8|24|UNS|2A|1 5/8-24 UNS 2A|1.625-24 UNS 2A|0.0013|1.6237|1.625|1.6165|-|1.5966|1.5922|1.5741|-|
1 5/8|24|UNS|2B|1 5/8-24 UNS 2B|1.625-24 UNS 2B|-|-|1.625|1.625|-|1.6037|1.5979|1.59|1.58|
1 11/16|6|UN|2A|1 11/16-6 UN 2A|1.688-6 UN 2A|0.0025|1.685|1.6875|1.6668|-|1.5767|1.5684|1.4866|-|
1 11/16|6|UN|2B|1 11/16-6 UN 2B|1.688-6 UN 2B|-|-|1.6875|1.6875|-|1.59|1.5792|1.538|1.507|
1 11/16|6|UN|3A|1 11/16-6 UN 3A|1.688-6 UN 3A|0|1.6875|1.6875|1.6693|-|1.5792|1.573|1.4891|-|
1 11/16|6|UN|3B|1 11/16-6 UN 3B|1.688-6 UN 3B|-|-|1.6875|1.6875|-|1.5873|1.5792|1.5271|1.507|
1 11/16|8|UN|2A|1 11/16-8 UN 2A|1.688-8 UN 2A|0.0022|1.6853|1.6875|1.6703|-|1.6041|1.5966|1.5365|-|
1 11/16|8|UN|2B|1 11/16-8 UN 2B|1.688-8 UN 2B|-|-|1.6875|1.6875|-|1.616|1.6063|1.577|1.552|
1 11/16|8|UN|3A|1 11/16-8 UN 3A|1.688-8 UN 3A|0|1.6875|1.6875|1.6725|-|1.6063|1.6007|1.5387|-|
1 11/16|8|UN|3B|1 11/16-8 UN 3B|1.688-8 UN 3B|-|-|1.6875|1.6875|-|1.6136|1.6063|1.5672|1.552|
1 11/16|12|UN|2A|1 11/16-12 UN 2A|1.688-12 UN 2A|0.0018|1.6857|1.6875|1.6743|-|1.6316|1.6256|1.5865|-|
1 11/16|12|UN|2B|1 11/16-12 UN 2B|1.688-12 UN 2B|-|-|1.6875|1.6875|-|1.6412|1.6334|1.615|1.597|
1 11/16|12|UN|3A|1 11/16-12 UN 3A|1.688-12 UN 3A|0|1.6875|1.6875|1.6761|-|1.6334|1.6289|1.5883|-|
1 11/16|12|UN|3B|1 11/16-12 UN 3B|1.688-12 UN 3B|-|-|1.6875|1.6875|-|1.6392|1.6334|1.6073|1.597|
1 11/16|16|UN|2A|1 11/16-16 UN 2A|1.688-16 UN 2A|0.0016|1.6859|1.6875|1.6765|-|1.6453|1.64|1.6114|-|
1 11/16|16|UN|2B|1 11/16-16 UN 2B|1.688-16 UN 2B|-|-|1.6875|1.6875|-|1.6538|1.6469|1.634|1.62|
1 11/16|16|UN|3A|1 11/16-16 UN 3A|1.688-16 UN 3A|0|1.6875|1.6875|1.6781|-|1.6469|1.6429|1.613|-|
1 11/16|16|UN|3B|1 11/16-16 UN 3B|1.688-16 UN 3B|-|-|1.6875|1.6875|-|1.6521|1.6469|1.6283|1.62|
1 11/16|18|UNEF|2A|1 11/16-18 UNEF 2A|1.688-18 UNEF 2A|0.0015|1.686|1.6875|1.6773|-|1.6499|1.6448|1.6199|-|
1 11/16|18|UNEF|2B|1 11/16-18 UNEF 2B|1.688-18 UNEF 2B|-|-|1.6875|1.6875|-|1.658|1.6514|1.64|1.627|
1 11/16|18|UNEF|3A|1 11/16-18 UNEF 3A|1.688-18 UNEF 3A|0|1.6875|1.6875|1.6788|-|1.6514|1.6476|1.6214|-|
1 11/16|18|UNEF|3B|1 11/16-18 UNEF 3B|1.688-18 UNEF 3B|-|-|1.6875|1.6875|-|1.6563|1.6514|1.6355|1.627|
1 11/16|20|UN|2A|1 11/16-20 UN 2A|1.688-20 UN 2A|0.0015|1.686|1.6875|1.6779|-|1.6535|1.6487|1.6265|-|
1 11/16|20|UN|2B|1 11/16-20 UN 2B|1.688-20 UN 2B|-|-|1.6875|1.6875|-|1.6613|1.655|1.645|1.633|
1 11/16|20|UN|3A|1 11/16-20 UN 3A|1.688-20 UN 3A|0|1.6875|1.6875|1.6794|-|1.655|1.6514|1.628|-|
1 11/16|20|UN|3B|1 11/16-20 UN 3B|1.688-20 UN 3B|-|-|1.6875|1.6875|-|1.6597|1.655|1.6412|1.633|
1 3/4|5|UNC|1A|1 3/4-5 UNC 1A|1.750-5 UNC 1A|0.0027|1.7473|1.75|1.7165|-|1.6174|1.604|1.5092|-|
1 3/4|5|UNC|1B|1 3/4-5 UNC 1B|1.750-5 UNC 1B|-|-|1.75|1.75|-|1.6375|1.6201|1.568|1.534|
1 3/4|5|UNC|2A|1 3/4-5 UNC 2A|1.750-5 UNC 2A|0.0027|1.7473|1.75|1.7268|1.7165|1.6174|1.6085|1.5092|-|
1 3/4|5|UNC|2B|1 3/4-5 UNC 2B|1.750-5 UNC 2B|-|-|1.75|1.75|-|1.6317|1.6201|1.568|1.534|
1 3/4|5|UNC|3A|1 3/4-5 UNC 3A|1.750-5 UNC 3A|0|1.75|1.75|1.7295|-|1.6201|1.6134|1.5119|-|
1 3/4|5|UNC|3B|1 3/4-5 UNC 3B|1.750-5 UNC 3B|-|-|1.75|1.75|-|1.6288|1.6201|1.5575|1.534|
1 3/4|6|UN|2A|1 3/4-6 UN 2A|1.750-6 UN 2A|0.0025|1.7475|1.75|1.7293|-|1.6392|1.6309|1.5491|-|
1 3/4|6|UN|2B|1 3/4-6 UN 2B|1.750-6 UN 2B|-|-|1.75|1.75|-|1.6525|1.6417|1.6|1.57|
1 3/4|6|UN|3A|1 3/4-6 UN 3A|1.750-6 UN 3A|0|1.75|1.75|1.7318|-|1.6417|1.6354|1.5516|-|
1 3/4|6|UN|3B|1 3/4-6 UN 3B|1.750-6 UN 3B|-|-|1.75|1.75|-|1.6498|1.6417|1.5896|1.57|
1 3/4|8|UN|2A|1 3/4-8 UN 2A|1.750-8 UN 2A|0.0023|1.7477|1.75|1.7327|1.7252|1.6665|1.659|1.5989|-|
1 3/4|8|UN|2B|1 3/4-8 UN 2B|1.750-8 UN 2B|-|-|1.75|1.75|-|1.6786|1.6688|1.64|1.615|
1 3/4|8|UN|3A|1 3/4-8 UN 3A|1.750-8 UN 3A|0|1.75|1.75|1.735|-|1.6688|1.6632|1.6012|-|
1 3/4|8|UN|3B|1 3/4-8 UN 3B|1.750-8 UN 3B|-|-|1.75|1.75|-|1.6762|1.6688|1.6297|1.615|
1 3/4|10|UNS|2A|1 3/4-10 UNS 2A|1.750-10 UNS 2A|0.0019|1.7481|1.75|1.7352|-|1.6831|1.6766|1.6291|-|
1 3/4|10|UNS|2B|1 3/4-10 UNS 2B|1.750-10 UNS 2B|-|-|1.75|1.75|-|1.6934|1.685|1.663|1.642|
1 3/4|12|UN|2A|1 3/4-12 UN 2A|1.750-12 UN 2A|0.0018|1.7482|1.75|1.7368|-|1.6941|1.6881|1.649|-|
1 3/4|12|UN|2B|1 3/4-12 UN 2B|1.750-12 UN 2B|-|-|1.75|1.75|-|1.7037|1.6959|1.678|1.66|
1 3/4|12|UN|3A|1 3/4-12 UN 3A|1.750-12 UN 3A|0|1.75|1.75|1.7386|-|1.6959|1.6914|1.6508|-|
1 3/4|12|UN|3B|1 3/4-12 UN 3B|1.750-12 UN 3B|-|-|1.75|1.75|-|1.7017|1.6959|1.6698|1.66|
1 3/4|14|UNS|2A|1 3/4-14 UNS 2A|1.750-14 UNS 2A|0.0017|1.7483|1.75|1.738|-|1.7019|1.6963|1.6632|-|
1 3/4|14|UNS|2B|1 3/4-14 UNS 2B|1.750-14 UNS 2B|-|-|1.75|1.75|-|1.7109|1.7036|1.688|1.673|
1 3/4|16|UN|2A|1 3/4-16 UN 2A|1.750-16 UN 2A|0.0016|1.7484|1.75|1.739|-|1.7078|1.7025|1.6739|-|
1 3/4|16|UN|2B|1 3/4-16 UN 2B|1.750-16 UN 2B|-|-|1.75|1.75|-|1.7163|1.7094|1.696|1.682|
1 3/4|16|UN|3A|1 3/4-16 UN 3A|1.750-16 UN 3A|0|1.75|1.75|1.7406|-|1.7094|1.7054|1.6755|-|
1 3/4|16|UN|3B|1 3/4-16 UN 3B|1.750-16 UN 3B|-|-|1.75|1.75|-|1.7146|1.7094|1.6908|1.682|
1 3/4|18|UNS|2A|1 3/4-18 UNS 2A|1.750-18 UNS 2A|0.0015|1.7485|1.75|1.7398|-|1.7124|1.7073|1.6824|-|
1 3/4|18|UNS|2B|1 3/4-18 UNS 2B|1.750-18 UNS 2B|-|-|1.75|1.75|-|1.7205|1.7139|1.703|1.69|
1 3/4|20|UN|2A|1 3/4-20 UN 2A|1.750-20 UN 2A|0.0015|1.7485|1.75|1.7404|-|1.716|1.7112|1.689|-|
1 3/4|20|UN|2B|1 3/4-20 UN 2B|1.750-20 UN 2B|-|-|1.75|1.75|-|1.7238|1.7175|1.707|1.696|
1 3/4|20|UN|3A|1 3/4-20 UN 3A|1.750-20 UN 3A|0|1.75|1.75|1.7419|-|1.7175|1.7139|1.6905|-|
1 3/4|20|UN|3B|1 3/4-20 UN 3B|1.750-20 UN 3B|-|-|1.75|1.75|-|1.7222|1.7175|1.7037|1.696|
1 13/16|6|UN|2A|1 13/16-6 UN 2A|1.813-6 UN 2A|0.0025|1.81|1.8125|1.7918|-|1.7017|1.6933|1.6116|-|
1 13/16|6|UN|2B|1 13/16-6 UN 2B|1.813-6 UN 2B|-|-|1.8125|1.8125|-|1.7151|1.7042|1.663|1.632|
1 13/16|6|UN|3A|1 13/16-6 UN 3A|1.813-6 UN 3A|0|1.8125|1.8125|1.7943|-|1.7042|1.6979|1.6141|-|
1 13/16|6|UN|3B|1 13/16-6 UN 3B|1.813-6 UN 3B|-|-|1.8125|1.8125|-|1.7124|1.7042|1.6521|1.632|
1 13/16|8|UN|2A|1 13/16-8 UN 2A|1.813-8 UN 2A|0.0023|1.8102|1.8125|1.7952|-|1.729|1.7214|1.6614|-|
1 13/16|8|UN|2B|1 13/16-8 UN 2B|1.813-8 UN 2B|-|-|1.8125|1.8125|-|1.7412|1.7313|1.702|1.677|
1 13/16|8|UN|3A|1 13/16-8 UN 3A|1.813-8 UN 3A|0|1.8125|1.8125|1.7975|-|1.7313|1.7256|1.6637|-|
1 13/16|8|UN|3B|1 13/16-8 UN 3B|1.813-8 UN 3B|-|-|1.8125|1.8125|-|1.7387|1.7313|1.6922|1.677|
1 13/16|12|UN|2A|1 13/16-12 UN 2A|1.813-12 UN 2A|0.0018|1.8107|1.8125|1.7993|-|1.7566|1.7506|1.7115|-|
1 13/16|12|UN|2B|1 13/16-12 UN 2B|1.813-12 UN 2B|-|-|1.8125|1.8125|-|1.7662|1.7584|1.74|1.722|
1 13/16|12|UN|3A|1 13/16-12 UN 3A|1.813-12 UN 3A|0|1.8125|1.8125|1.8011|-|1.7584|1.7539|1.7133|-|
1 13/16|12|UN|3B|1 13/16-12 UN 3B|1.813-12 UN 3B|-|-|1.8125|1.8125|-|1.7642|1.7584|1.7323|1.722|
1 13/16|16|UN|2A|1 13/16-16 UN 2A|1.813-16 UN 2A|0.0016|1.8109|1.8125|1.8015|-|1.7703|1.765|1.7364|-|
1 13/16|16|UN|2B|1 13/16-16 UN 2B|1.813-16 UN 2B|-|-|1.8125|1.8125|-|1.7788|1.7719|1.759|1.745|
1 13/16|16|UN|3A|1 13/16-16 UN 3A|1.813-16 UN 3A|0|1.8125|1.8125|1.8031|-|1.7719|1.7679|1.738|-|
1 13/16|16|UN|3B|1 13/16-16 UN 3B|1.813-16 UN 3B|-|-|1.8125|1.8125|-|1.7771|1.7719|1.7533|1.745|
1 13/16|20|UN|2A|1 13/16-20 UN 2A|1.813-20 UN 2A|0.0015|1.811|1.8125|1.8029|-|1.7785|1.7737|1.7515|-|
1 13/16|20|UN|2B|1 13/16-20 UN 2B|1.813-20 UN 2B|-|-|1.8125|1.8125|-|1.7863|1.78|1.77|1.758|
1 13/16|20|UN|3A|1 13/16-20 UN 3A|1.813-20 UN 3A|0|1.8125|1.8125|1.8044|-|1.78|1.7764|1.753|-|
1 13/16|20|UN|3B|1 13/16-20 UN 3B|1.813-20 UN 3B|-|-|1.8125|1.8125|-|1.7847|1.78|1.7662|1.758|
1 7/8|6|UN|2A|1 7/8-6 UN 2A|1.875-6 UN 2A|0.0025|1.8725|1.875|1.8543|-|1.7642|1.7558|1.6741|-|
1 7/8|6|UN|2B|1 7/8-6 UN 2B|1.875-6 UN 2B|-|-|1.875|1.875|-|1.7777|1.7667|1.725|1.695|
1 7/8|6|UN|3A|1 7/8-6 UN 3A|1.875-6 UN 3A|0|1.875|1.875|1.8568|-|1.7667|1.7604|1.6766|-|
1 7/8|6|UN|3B|1 7/8-6 UN 3B|1.875-6 UN 3B|-|-|1.875|1.875|-|1.7749|1.7667|1.7146|1.695|
1 7/8|8|UN|2A|1 7/8-8 UN 2A|1.875-8 UN 2A|0.0023|1.8727|1.875|1.8577|1.8502|1.7915|1.7838|1.7239|-|
1 7/8|8|UN|2B|1 7/8-8 UN 2B|1.875-8 UN 2B|-|-|1.875|1.875|-|1.8038|1.7938|1.765|1.74|
1 7/8|8|UN|3A|1 7/8-8 UN 3A|1.875-8 UN 3A|0|1.875|1.875|1.86|-|1.7938|1.7881|1.7262|-|
1 7/8|8|UN|3B|1 7/8-8 UN 3B|1.875-8 UN 3B|-|-|1.875|1.875|-|1.8013|1.7938|1.7547|1.74|
1 7/8|10|UNS|2A|1 7/8-10 UNS 2A|1.875-10 UNS 2A|0.0019|1.8731|1.875|1.8602|-|1.8081|1.8016|1.7541|-|
1 7/8|10|UNS|2B|1 7/8-10 UNS 2B|1.875-10 UNS 2B|-|-|1.875|1.875|-|1.8184|1.81|1.788|1.767|
1 7/8|12|UN|2A|1 7/8-12 UN 2A|1.875-12 UN 2A|0.0018|1.8732|1.875|1.8618|-|1.8191|1.8131|1.774|-|
1 7/8|12|UN|2B|1 7/8-12 UN 2B|1.875-12 UN 2B|-|-|1.875|1.875|-|1.8287|1.8209|1.803|1.785|
1 7/8|12|UN|3A|1 7/8-12 UN 3A|1.875-12 UN 3A|0|1.875|1.875|1.8636|-|1.8209|1.8164|1.7758|-|
1 7/8|12|UN|3B|1 7/8-12 UN 3B|1.875-12 UN 3B|-|-|1.875|1.875|-|1.8267|1.8209|1.7948|1.785|
1 7/8|14|UNS|2A|1 7/8-14 UNS 2A|1.875-14 UNS 2A|0.0017|1.8733|1.875|1.863|-|1.8269|1.8213|1.7883|-|
1 7/8|14|UNS|2B|1 7/8-14 UNS 2B|1.875-14 UNS 2B|-|-|1.875|1.875|-|1.8359|1.8286|1.814|1.798|
1 7/8|16|UN|2A|1 7/8-16 UN 2A|1.875-16 UN 2A|0.0016|1.8734|1.875|1.864|-|1.8328|1.8275|1.7989|-|
1 7/8|16|UN|2B|1 7/8-16 UN 2B|1.875-16 UN 2B|-|-|1.875|1.875|-|1.8413|1.8344|1.821|1.807|
1 7/8|16|UN|3A|1 7/8-16 UN 3A|1.875-16 UN 3A|0|1.875|1.875|1.8656|-|1.8344|1.8304|1.8005|-|
1 7/8|16|UN|3B|1 7/8-16 UN 3B|1.875-16 UN 3B|-|-|1.875|1.875|-|1.8396|1.8344|1.8158|1.807|
1 7/8|18|UNS|2A|1 7/8-18 UNS 2A|1.875-18 UNS 2A|0.0015|1.8735|1.875|1.8648|-|1.8374|1.8323|1.8074|-|
1 7/8|18|UNS|2B|1 7/8-18 UNS 2B|1.875-18 UNS 2B|-|-|1.875|1.875|-|1.8455|1.8389|1.828|1.815|
1 7/8|20|UN|2A|1 7/8-20 UN 2A|1.875-20 UN 2A|0.0015|1.8735|1.875|1.8654|-|1.841|1.8362|1.814|-|
1 7/8|20|UN|2B|1 7/8-20 UN 2B|1.875-20 UN 2B|-|-|1.875|1.875|-|1.8488|1.8425|1.832|1.821|
1 7/8|20|UN|3A|1 7/8-20 UN 3A|1.875-20 UN 3A|0|1.875|1.875|1.8669|-|1.8425|1.8389|1.8155|-|
1 7/8|20|UN|3B|1 7/8-20 UN 3B|1.875-20 UN 3B|-|-|1.875|1.875|-|1.8472|1.8425|1.8287|1.821|
1 15/16|6|UN|2A|1 15/16-6 UN 2A|1.938-6 UN 2A|0.0026|1.9349|1.9375|1.9167|-|1.8266|1.8181|1.7365|-|
1 15/16|6|UN|2B|1 15/16-6 UN 2B|1.938-6 UN 2B|-|-|1.9375|1.9375|-|1.8403|1.8292|1.788|1.757|
1 15/16|6|UN|3A|1 15/16-6 UN 3A|1.938-6 UN 3A|0|1.9375|1.9375|1.9193|-|1.8292|1.8228|1.7391|-|
1 15/16|6|UN|3B|1 15/16-6 UN 3B|1.938-6 UN 3B|-|-|1.9375|1.9375|-|1.8375|1.8292|1.7771|1.757|
1 15/16|8|UN|2A|1 15/16-8 UN 2A|1.938-8 UN 2A|0.0023|1.9352|1.9375|1.9202|-|1.854|1.8463|1.7864|-|
1 15/16|8|UN|2B|1 15/16-8 UN 2B|1.938-8 UN 2B|-|-|1.9375|1.9375|-|1.8663|1.8563|1.827|1.802|
1 15/16|8|UN|3A|1 15/16-8 UN 3A|1.938-8 UN 3A|0|1.9375|1.9375|1.9225|-|1.8563|1.8505|1.7887|-|
1 15/16|8|UN|3B|1 15/16-8 UN 3B|1.938-8 UN 3B|-|-|1.9375|1.9375|-|1.8638|1.8563|1.8172|1.802|
1 15/16|12|UN|2A|1 15/16-12 UN 2A|1.938-12 UN 2A|0.0018|1.9357|1.9375|1.9243|-|1.8816|1.8755|1.8365|-|
1 15/16|12|UN|2B|1 15/16-12 UN 2B|1.938-12 UN 2B|-|-|1.9375|1.9375|-|1.8913|1.8834|1.865|1.847|
1 15/16|12|UN|3A|1 15/16-12 UN 3A|1.938-12 UN 3A|0|1.9375|1.9375|1.9261|-|1.8834|1.8789|1.8383|-|
1 15/16|12|UN|3B|1 15/16-12 UN 3B|1.938-12 UN 3B|-|-|1.9375|1.9375|-|1.8893|1.8834|1.8573|1.847|
1 15/16|16|UN|2A|1 15/16-16 UN 2A|1.938-16 UN 2A|0.0016|1.9359|1.9375|1.9265|-|1.8953|1.8899|1.8614|-|
1 15/16|16|UN|2B|1 15/16-16 UN 2B|1.938-16 UN 2B|-|-|1.9375|1.9375|-|1.9039|1.8969|1.884|1.87|
1 15/16|16|UN|3A|1 15/16-16 UN 3A|1.938-16 UN 3A|0|1.9375|1.9375|1.9281|-|1.8969|1.8929|1.863|-|
1 15/16|16|UN|3B|1 15/16-16 UN 3B|1.938-16 UN 3B|-|-|1.9375|1.9375|-|1.9021|1.8969|1.8783|1.87|
1 15/16|20|UN|2A|1 15/16-20 UN 2A|1.938-20 UN 2A|0.0015|1.936|1.9375|1.9279|-|1.9035|1.8986|1.8765|-|
1 15/16|20|UN|2B|1 15/16-20 UN 2B|1.938-20 UN 2B|-|-|1.9375|1.9375|-|1.9114|1.905|1.895|1.883|
1 15/16|20|UN|3A|1 15/16-20 UN 3A|1.938-20 UN 3A|0|1.9375|1.9375|1.9294|-|1.905|1.9013|1.878|-|
1 15/16|20|UN|3B|1 15/16-20 UN 3B|1.938-20 UN 3B|-|-|1.9375|1.9375|-|1.9098|1.905|1.8912|1.883|
2|4.5|UNC|1B|2-4 1/2 UNC 1B|2.000-4.5 UNC 1B|-|-|2|2|-|1.8743|1.8557|1.795|1.759|
2|4.5|UNC|2B|2-4 1/2 UNC 2B|2.000-4.5 UNC 2B|-|-|2|2|-|1.8681|1.8557|1.795|1.759|
2|4.5|UNC|3B|2-4 1/2 UNC 3B|2.000-4.5 UNC 3B|-|-|2|2|-|1.865|1.8557|1.7861|1.759|
2|6|UN|2A|2-6 UN 2A|2.000-6 UN 2A|0.0026|1.9974|2|1.9792|-|1.8891|1.8805|1.799|-|
2|6|UN|2B|2-6 UN 2B|2.000-6 UN 2B|-|-|2|2|-|1.9028|1.8917|1.85|1.82|
2|6|UN|3A|2-6 UN 3A|2.000-6 UN 3A|0|2|2|1.9818|-|1.8917|1.8853|1.8016|-|
2|6|UN|3B|2-6 UN 3B|2.000-6 UN 3B|-|-|2|2|-|1.9|1.8917|1.8396|1.82|
2|8|UN|2A|2-8 UN 2A|2.000-8 UN 2A|0.0023|1.9977|2|1.9827|1.9752|1.9165|1.9087|1.8489|-|
2|8|UN|2B|2-8 UN 2B|2.000-8 UN 2B|-|-|2|2|-|1.9289|1.9188|1.89|1.865|
2|8|UN|3A|2-8 UN 3A|2.000-8 UN 3A|0|2|2|1.985|-|1.9188|1.913|1.8512|-|
2|8|UN|3B|2-8 UN 3B|2.000-8 UN 3B|-|-|2|2|-|1.9264|1.9188|1.8797|1.865|
2|10|UNS|2A|2-10 UNS 2A|2.000-10 UNS 2A|0.002|1.998|2|1.9851|-|1.933|1.9265|1.879|-|
2|10|UNS|2B|2-10 UNS 2B|2.000-10 UNS 2B|-|-|2|2|-|1.9435|1.935|1.913|1.892|
2|12|UN|2A|2-12 UN 2A|2.000-12 UN 2A|0.0018|1.9982|2|1.9868|-|1.9441|1.938|1.899|-|
2|12|UN|2B|2-12 UN 2B|2.000-12 UN 2B|-|-|2|2|-|1.9538|1.9459|1.928|1.91|
2|12|UN|3A|2-12 UN 3A|2.000-12 UN 3A|0|2|2|1.9886|-|1.9459|1.9414|1.9008|-|
2|12|UN|3B|2-12 UN 3B|2.000-12 UN 3B|-|-|2|2|-|1.9518|1.9459|1.9198|1.91|
2|14|UNS|2A|2-14 UNS 2A|2.000-14 UNS 2A|0.0017|1.9983|2|1.988|-|1.9519|1.9462|1.9133|-|
2|14|UNS|2B|2-14 UNS 2B|2.000-14 UNS 2B|-|-|2|2|-|1.961|1.9536|1.938|1.923|
2|16|UN|2A|2-16 UN 2A|2.000-16 UN 2A|0.0016|1.9984|2|1.989|-|1.9578|1.9524|1.9239|-|
2|16|UN|2B|2-16 UN 2B|2.000-16 UN 2B|-|-|2|2|-|1.9664|1.9594|1.946|1.932|
2|16|UN|3A|2-16 UN 3A|2.000-16 UN 3A|0|2|2|1.9906|-|1.9594|1.9554|1.9255|-|
2|16|UN|3B|2-16 UN 3B|2.000-16 UN 3B|-|-|2|2|-|1.9646|1.9594|1.9408|1.932|
2|18|UNS|2A|2-18 UNS 2A|2.000-18 UNS 2A|0.0015|1.9985|2|1.9898|-|1.9624|1.9573|1.9324|-|
2|18|UNS|2B|2-18 UNS 2B|2.000-18 UNS 2B|-|-|2|2|-|1.9706|1.9639|1.953|1.94|
2|20|UN|2A|2-20 UN 2A|2.000-20 UN 2A|0.0015|1.9985|2|1.9904|-|1.966|1.9611|1.939|-|
2|20|UN|2B|2-20 UN 2B|2.000-20 UN 2B|-|-|2|2|-|1.9739|1.9675|1.957|1.946|
2|20|UN|3A|2-20 UN 3A|2.000-20 UN 3A|0|2|2|1.9919|-|1.9675|1.9638|1.9405|-|
2|20|UN|3B|2-20 UN 3B|2.000-20 UN 3B|-|-|2|2|-|1.9723|1.9675|1.9537|1.946|
2|4.5|UNC|1A|2-4 1/2 UNC 1A|2.000-4.5 UNC 1A|0.0029|1.9971|2|1.9641|-|1.8528|1.8385|1.7324|-|
2|4.5|UNC|2A|2-4 1/2 UNC 2A|2.000-4.5 UNC 2A|0.0029|1.9971|2|1.9751|1.9641|1.8528|1.8433|1.7324|-|
2|4.5|UNC|3A|2-4 1/2 UNC 3A|2.000-4.5 UNC 3A|0|2|2|1.978|-|1.8557|1.8486|1.7353|-|
2 1/16|16|UNS|2A|2 1/16-16 UNS 2A|2.063-16 UNS 2A|0.0016|2.0609|2.0625|2.0515|-|2.0203|2.0149|1.9864|-|
2 1/16|16|UNS|2B|2 1/16-16 UNS 2B|2.063-16 UNS 2B|-|-|2.0625|2.0625|-|2.0289|2.0219|2.009|1.995|
2 1/16|16|UNS|3A|2 1/16-16 UNS 3A|2.063-16 UNS 3A|0|2.0625|2.0625|2.0531|-|2.0219|2.0179|1.988|-|
2 1/16|16|UNS|3B|2 1/16-16 UNS 3B|2.063-16 UNS 3B|-|-|2.0625|2.0625|-|2.0271|2.0219|2.0033|1.995|
2 1/8|6|UN|2A|2 1/8-6 UN 2A|2.125-6 UN 2A|0.0026|2.1224|2.125|2.1042|-|2.0141|2.0054|1.924|-|
2 1/8|6|UN|2B|2 1/8-6 UN 2B|2.125-6 UN 2B|-|-|2.125|2.125|-|2.028|2.0167|1.975|1.945|
2 1/8|6|UN|3A|2 1/8-6 UN 3A|2.125-6 UN 3A|0|2.125|2.125|2.1068|-|2.0167|2.0102|1.9266|-|
2 1/8|6|UN|3B|2 1/8-6 UN 3B|2.125-6 UN 3B|-|-|2.125|2.125|-|2.0251|2.0167|1.9646|1.945|
2 1/8|8|UN|2A|2 1/8-8 UN 2A|2.125-8 UN 2A|0.0024|2.1226|2.125|2.1076|2.1001|2.0414|2.0335|1.9738|-|
2 1/8|8|UN|2B|2 1/8-8 UN 2B|2.125-8 UN 2B|-|-|2.125|2.125|-|2.054|2.0438|2.015|1.99|
2 1/8|8|UN|3A|2 1/8-8 UN 3A|2.125-8 UN 3A|0|2.125|2.125|2.11|-|2.0438|2.0379|1.9762|-|
2 1/8|8|UN|3B|2 1/8-8 UN 3B|2.125-8 UN 3B|-|-|2.125|2.125|-|2.0515|2.0438|2.0047|1.99|
2 1/8|12|UN|2A|2 1/8-12 UN 2A|2.125-12 UN 2A|0.0018|2.1232|2.125|2.1118|-|2.0691|2.063|2.024|-|
2 1/8|12|UN|2B|2 1/8-12 UN 2B|2.125-12 UN 2B|-|-|2.125|2.125|-|2.0788|2.0709|2.053|2.035|
2 1/8|12|UN|3A|2 1/8-12 UN 3A|2.125-12 UN 3A|0|2.125|2.125|2.1136|-|2.0709|2.0664|2.0258|-|
2 1/8|12|UN|3B|2 1/8-12 UN 3B|2.125-12 UN 3B|-|-|2.125|2.125|-|2.0768|2.0709|2.0448|2.035|
2 1/8|16|UN|2A|2 1/8-16 UN 2A|2.125-16 UN 2A|0.0016|2.1234|2.125|2.114|-|2.0828|2.0774|2.0489|-|
2 1/8|16|UN|2B|2 1/8-16 UN 2B|2.125-16 UN 2B|-|-|2.125|2.125|-|2.0914|2.0844|2.071|2.057|
2 1/8|16|UN|3A|2 1/8-16 UN 3A|2.125-16 UN 3A|0|2.125|2.125|2.1156|-|2.0844|2.0803|2.0505|-|
2 1/8|16|UN|3B|2 1/8-16 UN 3B|2.125-16 UN 3B|-|-|2.125|2.125|-|2.0896|2.0844|2.0658|2.057|
2 1/8|20|UN|2A|2 1/8-20 UN 2A|2.125-20 UN 2A|0.0015|2.1235|2.125|2.1154|-|2.091|2.0861|2.064|-|
2 1/8|20|UN|2B|2 1/8-20 UN 2B|2.125-20 UN 2B|-|-|2.125|2.125|-|2.0989|2.0925|2.082|2.071|
2 1/8|20|UN|3A|2 1/8-20 UN 3A|2.125-20 UN 3A|0|2.125|2.125|2.1169|-|2.0925|2.0888|2.0655|-|
2 1/8|20|UN|3B|2 1/8-20 UN 3B|2.125-20 UN 3B|-|-|2.125|2.125|-|2.0973|2.0925|2.0787|2.071|
2 3/16|16|UNS|2A|2 3/16-16 UNS 2A|2.188-16 UNS 2A|0.0016|2.1859|2.1875|2.1765|-|2.1453|2.1399|2.1114|-|
2 3/16|16|UNS|2B|2 3/16-16 UNS 2B|2.188-16 UNS 2B|-|-|2.1875|2.1875|-|2.1539|2.1469|2.134|2.12|
2 3/16|16|UNS|3A|2 3/16-16 UNS 3A|2.188-16 UNS 3A|0|2.1875|2.1875|2.1781|-|2.1469|2.1428|2.113|-|
2 3/16|16|UNS|3B|2 3/16-16 UNS 3B|2.188-16 UNS 3B|-|-|2.1875|2.1875|-|2.1521|2.1469|2.1283|2.12|
2 1/4|4.5|UNC|1B|2 1/4-4 1/2 UNC 1B|2.250-4.5 UNC 1B|-|-|2.25|2.25|-|2.1247|2.1057|2.045|2.009|
2 1/4|4.5|UNC|2B|2 1/4-4 1/2 UNC 2B|2.250-4.5 UNC 2B|-|-|2.25|2.25|-|2.1183|2.1057|2.045|2.009|
2 1/4|4.5|UNC|3B|2 1/4-4 1/2 UNC 3B|2.250-4.5 UNC 3B|-|-|2.25|2.25|-|2.1152|2.1057|2.0361|2.009|
2 1/4|6|UN|2A|2 1/4-6 UN 2A|2.250-6 UN 2A|0.0026|2.2474|2.25|2.2292|-|2.1391|2.1303|2.049|-|
2 1/4|6|UN|2B|2 1/4-6 UN 2B|2.250-6 UN 2B|-|-|2.25|2.25|-|2.1531|2.1417|2.1|2.07|
2 1/4|6|UN|3A|2 1/4-6 UN 3A|2.250-6 UN 3A|0|2.25|2.25|2.2318|-|2.1417|2.1351|2.0516|-|
2 1/4|6|UN|3B|2 1/4-6 UN 3B|2.250-6 UN 3B|-|-|2.25|2.25|-|2.1502|2.1417|2.0896|2.07|
2 1/4|8|UN|2A|2 1/4-8 UN 2A|2.250-8 UN 2A|0.0024|2.2476|2.25|2.2326|2.2251|2.1664|2.1584|2.0988|-|
2 1/4|8|UN|2B|2 1/4-8 UN 2B|2.250-8 UN 2B|-|-|2.25|2.25|-|2.1792|2.1688|2.14|2.115|
2 1/4|8|UN|3A|2 1/4-8 UN 3A|2.250-8 UN 3A|0|2.25|2.25|2.235|-|2.1688|2.1628|2.1012|-|
2 1/4|8|UN|3B|2 1/4-8 UN 3B|2.250-8 UN 3B|-|-|2.25|2.25|-|2.1766|2.1688|2.1297|2.115|
2 1/4|10|UNS|2A|2 1/4-10 UNS 2A|2.250-10 UNS 2A|0.002|2.248|2.25|2.2351|-|2.183|2.1765|2.129|-|
2 1/4|10|UNS|2B|2 1/4-10 UNS 2B|2.250-10 UNS 2B|-|-|2.25|2.25|-|2.1935|2.185|2.163|2.142|
2 1/4|12|UN|2A|2 1/4-12 UN 2A|2.250-12 UN 2A|0.0018|2.2482|2.25|2.2368|-|2.1941|2.188|2.149|-|
2 1/4|12|UN|2B|2 1/4-12 UN 2B|2.250-12 UN 2B|-|-|2.25|2.25|-|2.2038|2.1959|2.178|2.16|
2 1/4|12|UN|3A|2 1/4-12 UN 3A|2.250-12 UN 3A|0|2.25|2.25|2.2386|-|2.1959|2.1914|2.1508|-|
2 1/4|12|UN|3B|2 1/4-12 UN 3B|2.250-12 UN 3B|-|-|2.25|2.25|-|2.2018|2.1959|2.1698|2.16|
2 1/4|14|UNS|2A|2 1/4-14 UNS 2A|2.250-14 UNS 2A|0.0017|2.2483|2.25|2.238|-|2.2019|2.1962|2.1633|-|
2 1/4|14|UNS|2B|2 1/4-14 UNS 2B|2.250-14 UNS 2B|-|-|2.25|2.25|-|2.211|2.2036|2.188|2.173|
2 1/4|16|UN|2A|2 1/4-16 UN 2A|2.250-16 UN 2A|0.0016|2.2484|2.25|2.239|-|2.2078|2.2024|2.1739|-|
2 1/4|16|UN|2B|2 1/4-16 UN 2B|2.250-16 UN 2B|-|-|2.25|2.25|-|2.2164|2.2094|2.196|2.182|
2 1/4|16|UN|3A|2 1/4-16 UN 3A|2.250-16 UN 3A|0|2.25|2.25|2.2406|-|2.2094|2.2053|2.1755|-|
2 1/4|16|UN|3B|2 1/4-16 UN 3B|2.250-16 UN 3B|-|-|2.25|2.25|-|2.2146|2.2094|2.1908|2.182|
2 1/4|18|UNS|2A|2 1/4-18 UNS 2A|2.250-18 UNS 2A|0.0015|2.2485|2.25|2.2398|-|2.2124|2.2073|2.1824|-|
2 1/4|18|UNS|2B|2 1/4-18 UNS 2B|2.250-18 UNS 2B|-|-|2.25|2.25|-|2.2206|2.2139|2.203|2.19|
2 1/4|20|UN|2A|2 1/4-20 UN 2A|2.250-20 UN 2A|0.0015|2.2485|2.25|2.2404|-|2.216|2.2111|2.189|-|
2 1/4|20|UN|2B|2 1/4-20 UN 2B|2.250-20 UN 2B|-|-|2.25|2.25|-|2.2239|2.2175|2.207|2.196|
2 1/4|20|UN|3A|2 1/4-20 UN 3A|2.250-20 UN 3A|0|2.25|2.25|2.2419|-|2.2175|2.2137|2.1905|-|
2 1/4|20|UN|3B|2 1/4-20 UN 3B|2.250-20 UN 3B|-|-|2.25|2.25|-|2.2223|2.2175|2.2037|2.196|
2 1/4|4.5|UNC|1A|2 1/4-4 1/2 UNC 1A|2.250-4.5 UNC 1A|0.0029|2.2471|2.25|2.2141|-|2.1028|2.0882|1.9824|-|
2 1/4|4.5|UNC|2A|2 1/4-4 1/2 UNC 2A|2.250-4.5 UNC 2A|0.0029|2.2471|2.25|2.2251|2.2141|2.1028|2.0931|1.9824|-|
2 1/4|4.5|UNC|3A|2 1/4-4 1/2 UNC 3A|2.250-4.5 UNC 3A|0|2.25|2.25|2.228|-|2.1057|2.0984|1.9853|-|
2 5/16|16|UNS|2A|2 5/16-16 UNS 2A|2.313-16 UNS 2A|0.0017|2.3108|2.3125|2.3014|-|2.2702|2.2647|2.2363|-|
2 5/16|16|UNS|2B|2 5/16-16 UNS 2B|2.313-16 UNS 2B|-|-|2.3125|2.3125|-|2.2791|2.2719|2.259|2.245|
2 5/16|16|UNS|3A|2 5/16-16 UNS 3A|2.313-16 UNS 3A|0|2.3125|2.3125|2.3031|-|2.2719|2.2678|2.238|-|
2 5/16|16|UNS|3B|2 5/16-16 UNS 3B|2.313-16 UNS 3B|-|-|2.3125|2.3125|-|2.2773|2.2719|2.2533|2.245|
2 3/8|6|UN|2A|2 3/8-6 UN 2A|2.375-6 UN 2A|0.0027|2.3723|2.375|2.3541|-|2.264|2.2551|2.1739|-|
2 3/8|6|UN|2B|2 3/8-6 UN 2B|2.375-6 UN 2B|-|-|2.375|2.375|-|2.2782|2.2667|2.226|2.195|
2 3/8|6|UN|3A|2 3/8-6 UN 3A|2.375-6 UN 3A|0|2.375|2.375|2.3568|-|2.2667|2.2601|2.1766|-|
2 3/8|6|UN|3B|2 3/8-6 UN 3B|2.375-6 UN 3B|-|-|2.375|2.375|-|2.2753|2.2667|2.2146|2.195|
2 3/8|8|UN|2A|2 3/8-8 UN 2A|2.375-8 UN 2A|0.0024|2.3726|2.375|2.3576|-|2.2914|2.2833|2.2238|-|
2 3/8|8|UN|2B|2 3/8-8 UN 2B|2.375-8 UN 2B|-|-|2.375|2.375|-|2.3043|2.2938|2.265|2.24|
2 3/8|8|UN|3A|2 3/8-8 UN 3A|2.375-8 UN 3A|0|2.375|2.375|2.36|-|2.2938|2.2878|2.2262|-|
2 3/8|8|UN|3B|2 3/8-8 UN 3B|2.375-8 UN 3B|-|-|2.375|2.375|-|2.3017|2.2938|2.2547|2.24|
2 3/8|12|UN|2A|2 3/8-12 UN 2A|2.375-12 UN 2A|0.0019|2.3731|2.375|2.3617|-|2.319|2.3128|2.2739|-|
2 3/8|12|UN|2B|2 3/8-12 UN 2B|2.375-12 UN 2B|-|-|2.375|2.375|-|2.329|2.3209|2.303|2.285|
2 3/8|12|UN|3A|2 3/8-12 UN 3A|2.375-12 UN 3A|0|2.375|2.375|2.3636|-|2.3209|2.3163|2.2758|-|
2 3/8|12|UN|3B|2 3/8-12 UN 3B|2.375-12 UN 3B|-|-|2.375|2.375|-|2.3269|2.3209|2.2948|2.285|
2 3/8|16|UN|2A|2 3/8-16 UN 2A|2.375-16 UN 2A|0.0017|2.3733|2.375|2.3639|-|2.3327|2.3272|2.2988|-|
2 3/8|16|UN|2B|2 3/8-16 UN 2B|2.375-16 UN 2B|-|-|2.375|2.375|-|2.3416|2.3344|2.321|2.307|
2 3/8|16|UN|3A|2 3/8-16 UN 3A|2.375-16 UN 3A|0|2.375|2.375|2.3656|-|2.3344|2.3303|2.3005|-|
2 3/8|16|UN|3B|2 3/8-16 UN 3B|2.375-16 UN 3B|-|-|2.375|2.375|-|2.3398|2.3344|2.3158|2.307|
2 3/8|20|UN|2A|2 3/8-20 UN 2A|2.375-20 UN 2A|0.0015|2.3735|2.375|2.3654|-|2.341|2.3359|2.314|-|
2 3/8|20|UN|2B|2 3/8-20 UN 2B|2.375-20 UN 2B|-|-|2.375|2.375|-|2.3491|2.3425|2.332|2.321|
2 3/8|20|UN|3A|2 3/8-20 UN 3A|2.375-20 UN 3A|0|2.375|2.375|2.3669|-|2.3425|2.3387|2.3155|-|
2 3/8|20|UN|3B|2 3/8-20 UN 3B|2.375-20 UN 3B|-|-|2.375|2.375|-|2.3475|2.3425|2.3287|2.321|
2 7/16|16|UNS|2A|2 7/16-16 UNS 2A|2.438-16 UNS 2A|0.0017|2.4358|2.4375|2.4264|-|2.3952|2.3897|2.3613|-|
2 7/16|16|UNS|2B|2 7/16-16 UNS 2B|2.438-16 UNS 2B|-|-|2.4375|2.4375|-|2.4041|2.3969|2.384|2.37|
2 7/16|16|UNS|3A|2 7/16-16 UNS 3A|2.438-16 UNS 3A|0|2.4375|2.4375|2.4281|-|2.3969|2.3928|2.363|-|
2 7/16|16|UNS|3B|2 7/16-16 UNS 3B|2.438-16 UNS 3B|-|-|2.4375|2.4375|-|2.4023|2.3969|2.3783|2.37|
2 1/2|4|UNC|1A|2 1/2-4 UNC 1A|2.500-4 UNC 1A|0.0031|2.4969|2.5|2.4612|-|2.3345|2.319|2.1992|-|
2 1/2|4|UNC|1B|2 1/2-4 UNC 1B|2.500-4 UNC 1B|-|-|2.5|2.5|-|2.3578|2.3376|2.267|2.229|
2 1/2|4|UNC|2A|2 1/2-4 UNC 2A|2.500-4 UNC 2A|0.0031|2.4969|2.5|2.4731|2.4612|2.3345|2.3241|2.1992|-|
2 1/2|4|UNC|2B|2 1/2-4 UNC 2B|2.500-4 UNC 2B|-|-|2.5|2.5|-|2.3511|2.3376|2.267|2.229|
2 1/2|4|UNC|3A|2 1/2-4 UNC 3A|2.500-4 UNC 3A|0|2.5|2.5|2.4762|-|2.3376|2.3298|2.2023|-|
2 1/2|4|UNC|3B|2 1/2-4 UNC 3B|2.500-4 UNC 3B|-|-|2.5|2.5|-|2.3477|2.3376|2.2594|2.229|
2 1/2|6|UN|2A|2 1/2-6 UN 2A|2.500-6 UN 2A|0.0027|2.4973|2.5|2.4791|-|2.389|2.38|2.2989|-|
2 1/2|6|UN|2B|2 1/2-6 UN 2B|2.500-6 UN 2B|-|-|2.5|2.5|-|2.4033|2.3917|2.35|2.32|
2 1/2|6|UN|3A|2 1/2-6 UN 3A|2.500-6 UN 3A|0|2.5|2.5|2.4818|-|2.3917|2.385|2.3016|-|
2 1/2|6|UN|3B|2 1/2-6 UN 3B|2.500-6 UN 3B|-|-|2.5|2.5|-|2.4004|2.3917|2.3396|2.32|
2 1/2|8|UN|2A|2 1/2-8 UN 2A|2.500-8 UN 2A|0.0024|2.4976|2.5|2.4826|2.4751|2.4164|2.4082|2.3488|-|
2 1/2|8|UN|2B|2 1/2-8 UN 2B|2.500-8 UN 2B|-|-|2.5|2.5|-|2.4294|2.4188|2.39|2.365|
2 1/2|8|UN|3A|2 1/2-8 UN 3A|2.500-8 UN 3A|0|2.5|2.5|2.485|-|2.4188|2.4127|2.3512|-|
2 1/2|8|UN|3B|2 1/2-8 UN 3B|2.500-8 UN 3B|-|-|2.5|2.5|-|2.4268|2.4188|2.3797|2.365|
2 1/2|10|UNS|2A|2 1/2-10 UNS 2A|2.500-10 UNS 2A|0.002|2.498|2.5|2.4851|-|2.433|2.4263|2.379|-|
2 1/2|10|UNS|2B|2 1/2-10 UNS 2B|2.500-10 UNS 2B|-|-|2.5|2.5|-|2.4437|2.435|2.413|2.392|
2 1/2|12|UN|2A|2 1/2-12 UN 2A|2.500-12 UN 2A|0.0019|2.4981|2.5|2.4867|-|2.444|2.4378|2.3989|-|
2 1/2|12|UN|2B|2 1/2-12 UN 2B|2.500-12 UN 2B|-|-|2.5|2.5|-|2.454|2.4459|2.428|2.41|
2 1/2|12|UN|3A|2 1/2-12 UN 3A|2.500-12 UN 3A|0|2.5|2.5|2.4886|-|2.4459|2.4413|2.4008|-|
2 1/2|12|UN|3B|2 1/2-12 UN 3B|2.500-12 UN 3B|-|-|2.5|2.5|-|2.4519|2.4459|2.4198|2.41|
2 1/2|14|UNS|2A|2 1/2-14 UNS 2A|2.500-14 UNS 2A|0.0017|2.4983|2.5|2.488|-|2.4519|2.4461|2.4133|-|
2 1/2|14|UNS|2B|2 1/2-14 UNS 2B|2.500-14 UNS 2B|-|-|2.5|2.5|-|2.4612|2.4536|2.438|2.423|
2 1/2|16|UN|2A|2 1/2-16 UN 2A|2.500-16 UN 2A|0.0017|2.4983|2.5|2.4889|-|2.4577|2.4522|2.4238|-|
2 1/2|16|UN|2B|2 1/2-16 UN 2B|2.500-16 UN 2B|-|-|2.5|2.5|-|2.4666|2.4594|2.446|2.432|
2 1/2|16|UN|3A|2 1/2-16 UN 3A|2.500-16 UN 3A|0|2.5|2.5|2.4906|-|2.4594|2.4553|2.4255|-|
2 1/2|16|UN|3B|2 1/2-16 UN 3B|2.500-16 UN 3B|-|-|2.5|2.5|-|2.4648|2.4594|2.4408|2.432|
2 1/2|18|UNS|2A|2 1/2-18 UNS 2A|2.500-18 UNS 2A|0.0016|2.4984|2.5|2.4897|-|2.4623|2.457|2.4323|-|
2 1/2|18|UNS|2B|2 1/2-18 UNS 2B|2.500-18 UNS 2B|-|-|2.5|2.5|-|2.4708|2.4639|2.453|2.44|
2 1/2|20|UN|2A|2 1/2-20 UN 2A|2.500-20 UN 2A|0.0015|2.4985|2.5|2.4904|-|2.466|2.4609|2.439|-|
2 1/2|20|UN|2B|2 1/2-20 UN 2B|2.500-20 UN 2B|-|-|2.5|2.5|-|2.4741|2.4675|2.457|2.446|
2 1/2|20|UN|3A|2 1/2-20 UN 3A|2.500-20 UN 3A|0|2.5|2.5|2.4919|-|2.4675|2.4637|2.4405|-|
2 1/2|20|UN|3B|2 1/2-20 UN 3B|2.500-20 UN 3B|-|-|2.5|2.5|-|2.4725|2.4675|2.4537|2.446|
2 5/8|6|UN|2A|2 5/8-6 UN 2A|2.625-6 UN 2A|0.0027|2.6223|2.625|2.6041|-|2.514|2.505|2.4239|-|
2 5/8|6|UN|2B|2 5/8-6 UN 2B|2.625-6 UN 2B|-|-|2.625|2.625|-|2.5285|2.5167|2.475|2.445|
2 5/8|6|UN|3A|2 5/8-6 UN 3A|2.625-6 UN 3A|0|2.625|2.625|2.6068|-|2.5167|2.5099|2.4266|-|
2 5/8|6|UN|3B|2 5/8-6 UN 3B|2.625-6 UN 3B|-|-|2.625|2.625|-|2.5255|2.5167|2.4646|2.445|
2 5/8|8|UN|2A|2 5/8-8 UN 2A|2.625-8 UN 2A|0.0025|2.6225|2.625|2.6075|-|2.5413|2.5331|2.4737|-|
2 5/8|8|UN|2B|2 5/8-8 UN 2B|2.625-8 UN 2B|-|-|2.625|2.625|-|2.5545|2.5438|2.515|2.49|
2 5/8|8|UN|3A|2 5/8-8 UN 3A|2.625-8 UN 3A|0|2.625|2.625|2.61|-|2.5438|2.5376|2.4762|-|
2 5/8|8|UN|3B|2 5/8-8 UN 3B|2.625-8 UN 3B|-|-|2.625|2.625|-|2.5518|2.5438|2.5047|2.49|
2 5/8|12|UN|2A|2 5/8-12 UN 2A|2.625-12 UN 2A|0.0019|2.6231|2.625|2.6117|-|2.569|2.5628|2.5239|-|
2 5/8|12|UN|2B|2 5/8-12 UN 2B|2.625-12 UN 2B|-|-|2.625|2.625|-|2.579|2.5709|2.553|2.535|
2 5/8|12|UN|3A|2 5/8-12 UN 3A|2.625-12 UN 3A|0|2.625|2.625|2.6136|-|2.5709|2.5663|2.5258|-|
2 5/8|12|UN|3B|2 5/8-12 UN 3B|2.625-12 UN 3B|-|-|2.625|2.625|-|2.5769|2.5709|2.5448|2.535|
2 5/8|16|UN|2A|2 5/8-16 UN 2A|2.625-16 UN 2A|0.0017|2.6233|2.625|2.6139|-|2.5827|2.5772|2.5488|-|
2 5/8|16|UN|2B|2 5/8-16 UN 2B|2.625-16 UN 2B|-|-|2.625|2.625|-|2.5916|2.5844|2.571|2.557|
2 5/8|16|UN|3A|2 5/8-16 UN 3A|2.625-16 UN 3A|0|2.625|2.625|2.6156|-|2.5844|2.5803|2.5505|-|
2 5/8|16|UN|3B|2 5/8-16 UN 3B|2.625-16 UN 3B|-|-|2.625|2.625|-|2.5898|2.5844|2.5658|2.557|
2 5/8|20|UN|2A|2 5/8-20 UN 2A|2.625-20 UN 2A|0.0015|2.6235|2.625|2.6154|-|2.591|2.5859|2.564|-|
2 5/8|20|UN|2B|2 5/8-20 UN 2B|2.625-20 UN 2B|-|-|2.625|2.625|-|2.5991|2.5925|2.582|2.571|
2 5/8|20|UN|3A|2 5/8-20 UN 3A|2.625-20 UN 3A|0|2.625|2.625|2.6169|-|2.5925|2.5887|2.5655|-|
2 5/8|20|UN|3B|2 5/8-20 UN 3B|2.625-20 UN 3B|-|-|2.625|2.625|-|2.5975|2.5925|2.5787|2.571|
2 3/4|4|UNC|1A|2 3/4-4 UNC 1A|2.750-4 UNC 1A|0.0032|2.7468|2.75|2.7111|-|2.5844|2.5686|2.4491|-|
2 3/4|4|UNC|1B|2 3/4-4 UNC 1B|2.750-4 UNC 1B|-|-|2.75|2.75|-|2.6082|2.5876|2.517|2.479|
2 3/4|4|UNC|2A|2 3/4-4 UNC 2A|2.750-4 UNC 2A|0.0032|2.7468|2.75|2.723|2.7111|2.5844|2.5739|2.4491|-|
2 3/4|4|UNC|2B|2 3/4-4 UNC 2B|2.750-4 UNC 2B|-|-|2.75|2.75|-|2.6013|2.5876|2.517|2.479|
2 3/4|4|UNC|3A|2 3/4-4 UNC 3A|2.750-4 UNC 3A|0|2.75|2.75|2.7262|-|2.5876|2.5797|2.4523|-|
2 3/4|4|UNC|3B|2 3/4-4 UNC 3B|2.750-4 UNC 3B|-|-|2.75|2.75|-|2.5979|2.5876|2.5094|2.479|
2 3/4|6|UN|2A|2 3/4-6 UN 2A|2.750-6 UN 2A|0.0027|2.7473|2.75|2.7291|-|2.639|2.6299|2.5489|-|
2 3/4|6|UN|2B|2 3/4-6 UN 2B|2.750-6 UN 2B|-|-|2.75|2.75|-|2.6536|2.6417|2.6|2.57|
2 3/4|6|UN|3A|2 3/4-6 UN 3A|2.750-6 UN 3A|0|2.75|2.75|2.7318|-|2.6417|2.6349|2.5516|-|
2 3/4|6|UN|3B|2 3/4-6 UN 3B|2.750-6 UN 3B|-|-|2.75|2.75|-|2.6506|2.6417|2.5896|2.57|
2 3/4|8|UN|2A|2 3/4-8 UN 2A|2.750-8 UN 2A|0.0025|2.7475|2.75|2.7325|2.725|2.6663|2.658|2.5987|-|
2 3/4|8|UN|2B|2 3/4-8 UN 2B|2.750-8 UN 2B|-|-|2.75|2.75|-|2.6796|2.6688|2.64|2.615|
2 3/4|8|UN|3A|2 3/4-8 UN 3A|2.750-8 UN 3A|0|2.75|2.75|2.735|-|2.6688|2.6625|2.6012|-|
2 3/4|8|UN|3B|2 3/4-8 UN 3B|2.750-8 UN 3B|-|-|2.75|2.75|-|2.6769|2.6688|2.6297|2.615|
2 3/4|10|UNS|2A|2 3/4-10 UNS 2A|2.750-10 UNS 2A|0.002|2.748|2.75|2.7351|-|2.683|2.6763|2.629|-|
2 3/4|10|UNS|2B|2 3/4-10 UNS 2B|2.750-10 UNS 2B|-|-|2.75|2.75|-|2.6937|2.685|2.663|2.642|
2 3/4|12|UN|2A|2 3/4-12 UN 2A|2.750-12 UN 2A|0.0019|2.7481|2.75|2.7367|-|2.694|2.6878|2.6489|-|
2 3/4|12|UN|2B|2 3/4-12 UN 2B|2.750-12 UN 2B|-|-|2.75|2.75|-|2.704|2.6959|2.678|2.66|
2 3/4|12|UN|3A|2 3/4-12 UN 3A|2.750-12 UN 3A|0|2.75|2.75|2.7386|-|2.6959|2.6913|2.6508|-|
2 3/4|12|UN|3B|2 3/4-12 UN 3B|2.750-12 UN 3B|-|-|2.75|2.75|-|2.7019|2.6959|2.6698|2.66|
2 3/4|14|UNS|2A|2 3/4-14 UNS 2A|2.750-14 UNS 2A|0.0017|2.7483|2.75|2.738|-|2.7019|2.6961|2.6633|-|
2 3/4|14|UNS|2B|2 3/4-14 UNS 2B|2.750-14 UNS 2B|-|-|2.75|2.75|-|2.7112|2.7036|2.688|2.673|
2 3/4|16|UN|2A|2 3/4-16 UN 2A|2.750-16 UN 2A|0.0017|2.7483|2.75|2.7389|-|2.7077|2.7022|2.6738|-|
2 3/4|16|UN|2B|2 3/4-16 UN 2B|2.750-16 UN 2B|-|-|2.75|2.75|-|2.7166|2.7094|2.696|2.682|
2 3/4|16|UN|3A|2 3/4-16 UN 3A|2.750-16 UN 3A|0|2.75|2.75|2.7406|-|2.7094|2.7053|2.6755|-|
2 3/4|16|UN|3B|2 3/4-16 UN 3B|2.750-16 UN 3B|-|-|2.75|2.75|-|2.7148|2.7094|2.6908|2.682|
2 3/4|18|UNS|2A|2 3/4-18 UNS 2A|2.750-18 UNS 2A|0.0016|2.7484|2.75|2.7397|-|2.7123|2.707|2.6823|-|
2 3/4|18|UNS|2B|2 3/4-18 UNS 2B|2.750-18 UNS 2B|-|-|2.75|2.75|-|2.7208|2.7139|2.703|2.69|
2 3/4|20|UN|2A|2 3/4-20 UN 2A|2.750-20 UN 2A|0.0015|2.7485|2.75|2.7404|-|2.716|2.7109|2.689|-|
2 3/4|20|UN|2B|2 3/4-20 UN 2B|2.750-20 UN 2B|-|-|2.75|2.75|-|2.7241|2.7175|2.707|2.696|
2 3/4|20|UN|3A|2 3/4-20 UN 3A|2.750-20 UN 3A|0|2.75|2.75|2.7419|-|2.7175|2.7137|2.6905|-|
2 3/4|20|UN|3B|2 3/4-20 UN 3B|2.750-20 UN 3B|-|-|2.75|2.75|-|2.7225|2.7175|2.7037|2.696|
2 7/8|6|UN|2A|2 7/8-6 UN 2A|2.875-6 UN 2A|0.0028|2.8722|2.875|2.854|-|2.7639|2.7547|2.6738|-|
2 7/8|6|UN|2B|2 7/8-6 UN 2B|2.875-6 UN 2B|-|-|2.875|2.875|-|2.7787|2.7667|2.725|2.695|
2 7/8|6|UN|3A|2 7/8-6 UN 3A|2.875-6 UN 3A|0|2.875|2.875|2.8568|-|2.7667|2.7598|2.6766|-|
2 7/8|6|UN|3B|2 7/8-6 UN 3B|2.875-6 UN 3B|-|-|2.875|2.875|-|2.7757|2.7667|2.7146|2.695|
2 7/8|8|UN|2A|2 7/8-8 UN 2A|2.875-8 UN 2A|0.0025|2.8725|2.875|2.8575|-|2.7913|2.7829|2.7237|-|
2 7/8|8|UN|2B|2 7/8-8 UN 2B|2.875-8 UN 2B|-|-|2.875|2.875|-|2.8048|2.7938|2.765|2.74|
2 7/8|8|UN|3A|2 7/8-8 UN 3A|2.875-8 UN 3A|0|2.875|2.875|2.86|-|2.7938|2.7875|2.7262|-|
2 7/8|8|UN|3B|2 7/8-8 UN 3B|2.875-8 UN 3B|-|-|2.875|2.875|-|2.802|2.7938|2.7547|2.74|
2 7/8|12|UN|2A|2 7/8-12 UN 2A|2.875-12 UN 2A|0.0019|2.8731|2.875|2.8617|-|2.819|2.8127|2.7739|-|
2 7/8|12|UN|2B|2 7/8-12 UN 2B|2.875-12 UN 2B|-|-|2.875|2.875|-|2.8291|2.8209|2.803|2.785|
2 7/8|12|UN|3A|2 7/8-12 UN 3A|2.875-12 UN 3A|0|2.875|2.875|2.8636|-|2.8209|2.8162|2.7758|-|
2 7/8|12|UN|3B|2 7/8-12 UN 3B|2.875-12 UN 3B|-|-|2.875|2.875|-|2.8271|2.8209|2.7948|2.785|
2 7/8|16|UN|2A|2 7/8-16 UN 2A|2.875-16 UN 2A|0.0017|2.8733|2.875|2.8639|-|2.8327|2.8271|2.7988|-|
2 7/8|16|UN|2B|2 7/8-16 UN 2B|2.875-16 UN 2B|-|-|2.875|2.875|-|2.8417|2.8344|2.821|2.807|
2 7/8|16|UN|3A|2 7/8-16 UN 3A|2.875-16 UN 3A|0|2.875|2.875|2.8656|-|2.8344|2.8302|2.8005|-|
2 7/8|16|UN|3B|2 7/8-16 UN 3B|2.875-16 UN 3B|-|-|2.875|2.875|-|2.8399|2.8344|2.8158|2.807|
2 7/8|20|UN|2A|2 7/8-20 UN 2A|2.875-20 UN 2A|0.0016|2.8734|2.875|2.8653|-|2.8409|2.8357|2.8139|-|
2 7/8|20|UN|2B|2 7/8-20 UN 2B|2.875-20 UN 2B|-|-|2.875|2.875|-|2.8493|2.8425|2.832|2.821|
2 7/8|20|UN|3A|2 7/8-20 UN 3A|2.875-20 UN 3A|0|2.875|2.875|2.8669|-|2.8425|2.8386|2.8155|-|
2 7/8|20|UN|3B|2 7/8-20 UN 3B|2.875-20 UN 3B|-|-|2.875|2.875|-|2.8476|2.8425|2.8287|2.821|
3|4|UNC|1A|3-4 UNC 1A|3.000-4 UNC 1A|0.0032|2.9968|3|2.9611|-|2.8344|2.8183|2.6991|-|
3|4|UNC|1B|3-4 UNC 1B|3.000-4 UNC 1B|-|-|3|3|-|2.8585|2.8376|2.767|2.729|
3|4|UNC|2A|3-4 UNC 2A|3.000-4 UNC 2A|0.0032|2.9968|3|2.973|2.9611|2.8344|2.8237|2.6991|-|
3|4|UNC|2B|3-4 UNC 2B|3.000-4 UNC 2B|-|-|3|3|-|2.8515|2.8376|2.767|2.729|
3|4|UNC|3A|3-4 UNC 3A|3.000-4 UNC 3A|0|3|3|2.9762|-|2.8376|2.8296|2.7023|-|
3|4|UNC|3B|3-4 UNC 3B|3.000-4 UNC 3B|-|-|3|3|-|2.848|2.8376|2.7594|2.729|
3|6|UN|2A|3-6 UN 2A|3.000-6 UN 2A|0.0028|2.9972|3|2.979|-|2.8889|2.8796|2.7988|-|
3|6|UN|2B|3-6 UN 2B|3.000-6 UN 2B|-|-|3|3|-|2.9038|2.8917|2.85|2.82|
3|6|UN|3A|3-6 UN 3A|3.000-6 UN 3A|0|3|3|2.9818|-|2.8917|2.8847|2.8016|-|
3|6|UN|3B|3-6 UN 3B|3.000-6 UN 3B|-|-|3|3|-|2.9008|2.8917|2.8396|2.82|
3|8|UN|2A|3-8 UN 2A|3.000-8 UN 2A|0.0026|2.9974|3|2.9824|2.9749|2.9162|2.9077|2.8486|-|
3|8|UN|2B|3-8 UN 2B|3.000-8 UN 2B|-|-|3|3|-|2.9299|2.9188|2.89|2.865|
3|8|UN|3A|3-8 UN 3A|3.000-8 UN 3A|0|3|3|2.985|-|2.9188|2.9124|2.8512|-|
3|8|UN|3B|3-8 UN 3B|3.000-8 UN 3B|-|-|3|3|-|2.9271|2.9188|2.8797|2.865|
3|10|UNS|2A|3-10 UNS 2A|3.000-10 UNS 2A|0.002|2.998|3|2.9851|-|2.933|2.9262|2.879|-|
3|10|UNS|2B|3-10 UNS 2B|3.000-10 UNS 2B|-|-|3|3|-|2.9439|2.935|2.913|2.892|
3|12|UN|2A|3-12 UN 2A|3.000-12 UN 2A|0.0019|2.9981|3|2.9867|-|2.944|2.9377|2.8989|-|
3|12|UN|2B|3-12 UN 2B|3.000-12 UN 2B|-|-|3|3|-|2.9541|2.9459|2.928|2.91|
3|12|UN|3A|3-12 UN 3A|3.000-12 UN 3A|0|3|3|2.9886|-|2.9459|2.9412|2.9008|-|
3|12|UN|3B|3-12 UN 3B|3.000-12 UN 3B|-|-|3|3|-|2.9521|2.9459|2.9198|2.91|
3|14|UNS|2A|3-14 UNS 2A|3.000-14 UNS 2A|0.0018|2.9982|3|2.9879|-|2.9518|2.9459|2.9132|-|
3|14|UNS|2B|3-14 UNS 2B|3.000-14 UNS 2B|-|-|3|3|-|2.9613|2.9536|2.938|2.923|
3|16|UN|2A|3-16 UN 2A|3.000-16 UN 2A|0.0017|2.9983|3|2.9889|-|2.9577|2.9521|2.9238|-|
3|16|UN|2B|3-16 UN 2B|3.000-16 UN 2B|-|-|3|3|-|2.9667|2.9594|2.946|2.932|
3|16|UN|3A|3-16 UN 3A|3.000-16 UN 3A|0|3|3|2.9906|-|2.9594|2.9552|2.9255|-|
3|16|UN|3B|3-16 UN 3B|3.000-16 UN 3B|-|-|3|3|-|2.9649|2.9594|2.9408|2.932|
3|18|UNS|2A|3-18 UNS 2A|3.000-18 UNS 2A|0.0016|2.9984|3|2.9897|-|2.9623|2.9569|2.9323|-|
3|18|UNS|2B|3-18 UNS 2B|3.000-18 UNS 2B|-|-|3|3|-|2.9709|2.9639|2.953|2.94|
3|20|UN|2A|3-20 UN 2A|3.000-20 UN 2A|0.0016|2.9984|3|2.9903|-|2.9659|2.9607|2.9389|-|
3|20|UN|2B|3-20 UN 2B|3.000-20 UN 2B|-|-|3|3|-|2.9743|2.9675|2.957|2.946|
3|20|UN|3A|3-20 UN 3A|3.000-20 UN 3A|0|3|3|2.9919|-|2.9675|2.9636|2.9405|-|
3|20|UN|3B|3-20 UN 3B|3.000-20 UN 3B|-|-|3|3|-|2.9726|2.9675|2.9537|2.946|
3 1/8|6|UN|2A|3 1/8-6 UN 2A|3.125-6 UN 2A|0.0028|3.1222|3.125|3.104|-|3.0139|3.0045|2.9238|-|
3 1/8|6|UN|2B|3 1/8-6 UN 2B|3.125-6 UN 2B|-|-|3.125|3.125|-|3.0289|3.0167|2.975|2.945|
3 1/8|6|UN|3A|3 1/8-6 UN 3A|3.125-6 UN 3A|0|3.125|3.125|3.1068|-|3.0167|3.0097|2.9266|-|
3 1/8|6|UN|3B|3 1/8-6 UN 3B|3.125-6 UN 3B|-|-|3.125|3.125|-|3.0259|3.0167|2.9646|2.945|
3 1/8|8|UN|2A|3 1/8-8 UN 2A|3.125-8 UN 2A|0.0026|3.1224|3.125|3.1074|-|3.0412|3.0326|2.9736|-|
3 1/8|8|UN|2B|3 1/8-8 UN 2B|3.125-8 UN 2B|-|-|3.125|3.125|-|3.055|3.0438|3.015|2.99|
3 1/8|8|UN|3A|3 1/8-8 UN 3A|3.125-8 UN 3A|0|3.125|3.125|3.11|-|3.0438|3.0374|2.9762|-|
3 1/8|8|UN|3B|3 1/8-8 UN 3B|3.125-8 UN 3B|-|-|3.125|3.125|-|3.0522|3.0438|3.0047|2.99|
3 1/8|12|UN|2A|3 1/8-12 UN 2A|3.125-12 UN 2A|0.0019|3.1231|3.125|3.1117|-|3.069|3.0627|3.0239|-|
3 1/8|12|UN|2B|3 1/8-12 UN 2B|3.125-12 UN 2B|-|-|3.125|3.125|-|3.0791|3.0709|3.053|3.035|
3 1/8|12|UN|3A|3 1/8-12 UN 3A|3.125-12 UN 3A|0|3.125|3.125|3.1136|-|3.0709|3.0662|3.0258|-|
3 1/8|12|UN|3B|3 1/8-12 UN 3B|3.125-12 UN 3B|-|-|3.125|3.125|-|3.0771|3.0709|3.0448|3.035|
3 1/8|16|UN|2A|3 1/8-16 UN 2A|3.125-16 UN 2A|0.0017|3.1233|3.125|3.1139|-|3.0827|3.0771|3.0488|-|
3 1/8|16|UN|2B|3 1/8-16 UN 2B|3.125-16 UN 2B|-|-|3.125|3.125|-|3.0917|3.0844|3.071|3.057|
3 1/8|16|UN|3A|3 1/8-16 UN 3A|3.125-16 UN 3A|0|3.125|3.125|3.1156|-|3.0844|3.0802|3.0505|-|
3 1/8|16|UN|3B|3 1/8-16 UN 3B|3.125-16 UN 3B|-|-|3.125|3.125|-|3.0899|3.0844|3.0658|3.057|
3 1/4|4|UNC|1A|3 1/4-4 UNC 1A|3.250-4 UNC 1A|0.0033|3.2467|3.25|3.211|-|3.0843|3.068|2.949|-|
3 1/4|4|UNC|1B|3 1/4-4 UNC 1B|3.250-4 UNC 1B|-|-|3.25|3.25|-|3.1088|3.0876|3.017|2.979|
3 1/4|4|UNC|2A|3 1/4-4 UNC 2A|3.250-4 UNC 2A|0.0033|3.2467|3.25|3.2229|3.211|3.0843|3.0734|2.949|-|
3 1/4|4|UNC|2B|3 1/4-4 UNC 2B|3.250-4 UNC 2B|-|-|3.25|3.25|-|3.1017|3.0876|3.017|2.979|
3 1/4|4|UNC|3A|3 1/4-4 UNC 3A|3.250-4 UNC 3A|0|3.25|3.25|3.2262|-|3.0876|3.0794|2.9523|-|
3 1/4|4|UNC|3B|3 1/4-4 UNC 3B|3.250-4 UNC 3B|-|-|3.25|3.25|-|3.0982|3.0876|3.0094|2.979|
3 1/4|6|UN|2A|3 1/4-6 UN 2A|3.250-6 UN 2A|0.0028|3.2472|3.25|3.229|-|3.1389|3.1294|3.0488|-|
3 1/4|6|UN|2B|3 1/4-6 UN 2B|3.250-6 UN 2B|-|-|3.25|3.25|-|3.154|3.1417|3.1|3.07|
3 1/4|6|UN|3A|3 1/4-6 UN 3A|3.250-6 UN 3A|0|3.25|3.25|3.2318|-|3.1417|3.1346|3.0516|-|
3 1/4|6|UN|3B|3 1/4-6 UN 3B|3.250-6 UN 3B|-|-|3.25|3.25|-|3.1509|3.1417|3.0896|3.07|
3 1/4|8|UN|2A|3 1/4-8 UN 2A|3.250-8 UN 2A|0.0026|3.2474|3.25|3.2324|3.2249|3.1662|3.1575|3.0986|-|
3 1/4|8|UN|2B|3 1/4-8 UN 2B|3.250-8 UN 2B|-|-|3.25|3.25|-|3.1801|3.1688|3.14|3.115|
3 1/4|8|UN|3A|3 1/4-8 UN 3A|3.250-8 UN 3A|0|3.25|3.25|3.235|-|3.1688|3.1623|3.1012|-|
3 1/4|8|UN|3B|3 1/4-8 UN 3B|3.250-8 UN 3B|-|-|3.25|3.25|-|3.1773|3.1688|3.1297|3.115|
3 1/4|10|UNS|2A|3 1/4-10 UNS 2A|3.250-10 UNS 2A|0.002|3.248|3.25|3.2351|-|3.183|3.1762|3.129|-|
3 1/4|10|UNS|2B|3 1/4-10 UNS 2B|3.250-10 UNS 2B|-|-|3.25|3.25|-|3.1939|3.185|3.163|3.142|
3 1/4|12|UN|2A|3 1/4-12 UN 2A|3.250-12 UN 2A|0.0019|3.2481|3.25|3.2367|-|3.194|3.1877|3.1489|-|
3 1/4|12|UN|2B|3 1/4-12 UN 2B|3.250-12 UN 2B|-|-|3.25|3.25|-|3.2041|3.1959|3.178|3.16|
3 1/4|12|UN|3A|3 1/4-12 UN 3A|3.250-12 UN 3A|0|3.25|3.25|3.2386|-|3.1959|3.1912|3.1508|-|
3 1/4|12|UN|3B|3 1/4-12 UN 3B|3.250-12 UN 3B|-|-|3.25|3.25|-|3.2041|3.1959|3.1698|3.16|
3 1/4|14|UNS|2A|3 1/4-14 UNS 2A|3.250-14 UNS 2A|0.0018|3.2482|3.25|3.2379|-|3.2018|3.1959|3.1632|-|
3 1/4|14|UNS|2B|3 1/4-14 UNS 2B|3.250-14 UNS 2B|-|-|3.25|3.25|-|3.2113|3.2036|3.188|3.173|
3 1/4|16|UN|2A|3 1/4-16 UN 2A|3.250-16 UN 2A|0.0017|3.2483|3.25|3.2389|-|3.2077|3.2021|3.1738|-|
3 1/4|16|UN|2B|3 1/4-16 UN 2B|3.250-16 UN 2B|-|-|3.25|3.25|-|3.2167|3.2094|3.196|3.182|
3 1/4|16|UN|3A|3 1/4-16 UN 3A|3.250-16 UN 3A|0|3.25|3.25|3.2406|-|3.2094|3.2052|3.1755|-|
3 1/4|16|UN|3B|3 1/4-16 UN 3B|3.250-16 UN 3B|-|-|3.25|3.25|-|3.2149|3.2094|3.1908|3.182|
3 1/4|18|UNS|2A|3 1/4-18 UNS 2A|3.250-18 UNS 2A|0.0016|3.2484|3.25|3.2397|-|3.2123|3.2069|3.1823|-|
3 1/4|18|UNS|2B|3 1/4-18 UNS 2B|3.250-18 UNS 2B|-|-|3.25|3.25|-|3.2209|3.2139|3.203|3.19|
3 3/8|6|UN|2A|3 3/8-6 UN 2A|3.375-6 UN 2A|0.0029|3.3721|3.375|3.3539|-|3.2638|3.2543|3.1737|-|
3 3/8|6|UN|2B|3 3/8-6 UN 2B|3.375-6 UN 2B|-|-|3.375|3.375|-|3.2791|3.2667|3.225|3.195|
3 3/8|6|UN|3A|3 3/8-6 UN 3A|3.375-6 UN 3A|0|3.375|3.375|3.3568|-|3.2667|3.2595|3.1766|-|
3 3/8|6|UN|3B|3 3/8-6 UN 3B|3.375-6 UN 3B|-|-|3.375|3.375|-|3.276|3.2667|3.2146|3.195|
3 3/8|8|UN|2A|3 3/8-8 UN 2A|3.375-8 UN 2A|0.0026|3.3724|3.375|3.3574|-|3.2912|3.2824|3.2236|-|
3 3/8|8|UN|2B|3 3/8-8 UN 2B|3.375-8 UN 2B|-|-|3.375|3.375|-|3.3052|3.2938|3.265|3.24|
3 3/8|8|UN|3A|3 3/8-8 UN 3A|3.375-8 UN 3A|0|3.375|3.375|3.36|-|3.2938|3.2872|3.2262|-|
3 3/8|8|UN|3B|3 3/8-8 UN 3B|3.375-8 UN 3B|-|-|3.375|3.375|-|3.3023|3.2938|3.2547|3.24|
3 3/8|12|UN|2A|3 3/8-12 UN 2A|3.375-12 UN 2A|0.0019|3.3731|3.375|3.3617|-|3.319|3.3126|3.2739|-|
3 3/8|12|UN|2B|3 3/8-12 UN 2B|3.375-12 UN 2B|-|-|3.375|3.375|-|3.3293|3.3209|3.303|3.285|
3 3/8|12|UN|3A|3 3/8-12 UN 3A|3.375-12 UN 3A|0|3.375|3.375|3.3636|-|3.3209|3.3161|3.2758|-|
3 3/8|12|UN|3B|3 3/8-12 UN 3B|3.375-12 UN 3B|-|-|3.375|3.375|-|3.3272|3.3209|3.2948|3.285|
3 3/8|16|UN|2A|3 3/8-16 UN 2A|3.375-16 UN 2A|0.0017|3.3733|3.375|3.3639|-|3.3327|3.3269|3.2988|-|
3 3/8|16|UN|2B|3 3/8-16 UN 2B|3.375-16 UN 2B|-|-|3.375|3.375|-|3.3419|3.3344|3.321|3.307|
3 3/8|16|UN|3A|3 3/8-16 UN 3A|3.375-16 UN 3A|0|3.375|3.375|3.3656|-|3.3344|3.3301|3.3005|-|
3 3/8|16|UN|3B|3 3/8-16 UN 3B|3.375-16 UN 3B|-|-|3.375|3.375|-|3.34|3.3344|3.3158|3.307|
3 1/2|4|UNC|1A|3 1/2-4 UNC 1A|3.500-4 UNC 1A|0.0033|3.4967|3.5|3.461|-|3.3343|3.3177|3.199|-|
3 1/2|4|UNC|1B|3 1/2-4 UNC 1B|3.500-4 UNC 1B|-|-|3.5|3.5|-|3.3591|3.3376|3.267|3.229|
3 1/2|4|UNC|2A|3 1/2-4 UNC 2A|3.500-4 UNC 2A|0.0033|3.4967|3.5|3.4729|3.461|3.3343|3.3233|3.199|-|
3 1/2|4|UNC|2B|3 1/2-4 UNC 2B|3.500-4 UNC 2B|-|-|3.5|3.5|-|3.3519|3.3376|3.267|3.229|
3 1/2|4|UNC|3A|3 1/2-4 UNC 3A|3.500-4 UNC 3A|0|3.5|3.5|3.4762|-|3.3376|3.3293|3.2023|-|
3 1/2|4|UNC|3B|3 1/2-4 UNC 3B|3.500-4 UNC 3B|-|-|3.5|3.5|-|3.3484|3.3376|3.2594|3.229|
3 1/2|6|UN|2A|3 1/2-6 UN 2A|3.500-6 UN 2A|0.0029|3.4971|3.5|3.4789|-|3.3888|3.3792|3.2987|-|
3 1/2|6|UN|2B|3 1/2-6 UN 2B|3.500-6 UN 2B|-|-|3.5|3.5|-|3.4042|3.3917|3.35|3.32|
3 1/2|6|UN|3A|3 1/2-6 UN 3A|3.500-6 UN 3A|0|3.5|3.5|3.4818|-|3.3917|3.3845|3.3016|-|
3 1/2|6|UN|3B|3 1/2-6 UN 3B|3.500-6 UN 3B|-|-|3.5|3.5|-|3.4011|3.3917|3.3396|3.32|
3 1/2|8|UN|2A|3 1/2-8 UN 2A|3.500-8 UN 2A|0.0026|3.4974|3.5|3.4824|3.4749|3.4162|3.4074|3.3486|-|
3 1/2|8|UN|2B|3 1/2-8 UN 2B|3.500-8 UN 2B|-|-|3.5|3.5|-|3.4303|3.4188|3.39|3.365|
3 1/2|8|UN|3A|3 1/2-8 UN 3A|3.500-8 UN 3A|0|3.5|3.5|3.485|-|3.4188|3.4122|3.3512|-|
3 1/2|8|UN|3B|3 1/2-8 UN 3B|3.500-8 UN 3B|-|-|3.5|3.5|-|3.4274|3.4188|3.3797|3.365|
3 1/2|10|UNS|2A|3 1/2-10 UNS 2A|3.500-10 UNS 2A|0.0021|3.4979|3.5|3.485|-|3.4329|3.426|3.3789|-|
3 1/2|10|UNS|2B|3 1/2-10 UNS 2B|3.500-10 UNS 2B|-|-|3.5|3.5|-|3.444|3.435|3.413|3.392|
3 1/2|12|UN|2A|3 1/2-12 UN 2A|3.500-12 UN 2A|0.0019|3.4981|3.5|3.4867|-|3.444|3.4376|3.3989|-|
3 1/2|12|UN|2B|3 1/2-12 UN 2B|3.500-12 UN 2B|-|-|3.5|3.5|-|3.4543|3.4459|3.428|3.41|
3 1/2|12|UN|3A|3 1/2-12 UN 3A|3.500-12 UN 3A|0|3.5|3.5|3.4886|-|3.4459|3.4411|3.4008|-|
3 1/2|12|UN|3B|3 1/2-12 UN 3B|3.500-12 UN 3B|-|-|3.5|3.5|-|3.4522|3.4459|3.4198|3.41|
3 1/2|14|UNS|2A|3 1/2-14 UNS 2A|3.500-14 UNS 2A|0.0018|3.4982|3.5|3.4879|-|3.4518|3.4457|3.4132|-|
3 1/2|14|UNS|2B|3 1/2-14 UNS 2B|3.500-14 UNS 2B|-|-|3.5|3.5|-|3.4615|3.4536|3.438|3.423|
3 1/2|16|UN|2A|3 1/2-16 UN 2A|3.500-16 UN 2A|0.0017|3.4983|3.5|3.4889|-|3.4577|3.4519|3.4238|-|
3 1/2|16|UN|2B|3 1/2-16 UN 2B|3.500-16 UN 2B|-|-|3.5|3.5|-|3.4669|3.4594|3.446|3.432|
3 1/2|16|UN|3A|3 1/2-16 UN 3A|3.500-16 UN 3A|0|3.5|3.5|3.4906|-|3.4594|3.4551|3.4255|-|
3 1/2|16|UN|3B|3 1/2-16 UN 3B|3.500-16 UN 3B|-|-|3.5|3.5|-|3.465|3.4594|3.4408|3.432|
3 1/2|18|UNS|2A|3 1/2-18 UNS 2A|3.500-18 UNS 2A|0.0017|3.4983|3.5|3.4896|-|3.4622|3.4567|3.4322|-|
3 1/2|18|UNS|2B|3 1/2-18 UNS 2B|3.500-18 UNS 2B|-|-|3.5|3.5|-|3.4711|3.4639|3.453|3.44|
3 5/8|6|UN|2A|3 5/8-6 UN 2A|3.625-6 UN 2A|0.0029|3.6221|3.625|3.6039|-|3.5138|3.5041|3.4237|-|
3 5/8|6|UN|2B|3 5/8-6 UN 2B|3.625-6 UN 2B|-|-|3.625|3.625|-|3.5293|3.5167|3.475|3.445|
3 5/8|6|UN|3A|3 5/8-6 UN 3A|3.625-6 UN 3A|0|3.625|3.625|3.6068|-|3.5167|3.5094|3.4266|-|
3 5/8|6|UN|3B|3 5/8-6 UN 3B|3.625-6 UN 3B|-|-|3.625|3.625|-|3.5262|3.5167|3.4646|3.445|
3 5/8|8|UN|2A|3 5/8-8 UN 2A|3.625-8 UN 2A|0.0027|3.6223|3.625|3.6073|-|3.5411|3.5322|3.4735|-|
3 5/8|8|UN|2B|3 5/8-8 UN 2B|3.625-8 UN 2B|-|-|3.625|3.625|-|3.5554|3.5438|3.515|3.49|
3 5/8|8|UN|3A|3 5/8-8 UN 3A|3.625-8 UN 3A|0|3.625|3.625|3.61|-|3.5438|3.5371|3.4762|-|
3 5/8|8|UN|3B|3 5/8-8 UN 3B|3.625-8 UN 3B|-|-|3.625|3.625|-|3.5525|3.5438|3.5047|3.49|
3 5/8|12|UN|2A|3 5/8-12 UN 2A|3.625-12 UN 2A|0.0019|3.6231|3.625|3.6117|-|3.569|3.5626|3.5239|-|
3 5/8|12|UN|2B|3 5/8-12 UN 2B|3.625-12 UN 2B|-|-|3.625|3.625|-|3.5793|3.5709|3.553|3.535|
3 5/8|12|UN|3A|3 5/8-12 UN 3A|3.625-12 UN 3A|0|3.625|3.625|3.6136|-|3.5709|3.5661|3.5258|-|
3 5/8|12|UN|3B|3 5/8-12 UN 3B|3.625-12 UN 3B|-|-|3.625|3.625|-|3.5772|3.5709|3.5448|3.535|
3 5/8|16|UN|2A|3 5/8-16 UN 2A|3.625-16 UN 2A|0.0017|3.6233|3.625|3.6139|-|3.5827|3.5769|3.5488|-|
3 5/8|16|UN|2B|3 5/8-16 UN 2B|3.625-16 UN 2B|-|-|3.625|3.625|-|3.5919|3.5844|3.571|3.557|
3 5/8|16|UN|3A|3 5/8-16 UN 3A|3.625-16 UN 3A|0|3.625|3.625|3.6156|-|3.5844|3.5801|3.5505|-|
3 5/8|16|UN|3B|3 5/8-16 UN 3B|3.625-16 UN 3B|-|-|3.625|3.625|-|3.59|3.5844|3.5658|3.557|
3 3/4|4|UNC|1A|3 3/4-4 UNC 1A|3.750-4 UNC 1A|0.0034|3.7466|3.75|3.7109|-|3.5842|3.5674|3.4489|-|
3 3/4|4|UNC|1B|3 3/4-4 UNC 1B|3.750-4 UNC 1B|-|-|3.75|3.75|-|3.6094|3.5876|3.517|3.479|
3 3/4|4|UNC|2A|3 3/4-4 UNC 2A|3.750-4 UNC 2A|0.0034|3.7466|3.75|3.7228|3.7109|3.5842|3.573|3.4489|-|
3 3/4|4|UNC|2B|3 3/4-4 UNC 2B|3.750-4 UNC 2B|-|-|3.75|3.75|-|3.6021|3.5876|3.517|3.479|
3 3/4|4|UNC|3A|3 3/4-4 UNC 3A|3.750-4 UNC 3A|0|3.75|3.75|3.7262|-|3.5876|3.5792|3.4523|-|
3 3/4|4|UNC|3B|3 3/4-4 UNC 3B|3.750-4 UNC 3B|-|-|3.75|3.75|-|3.5985|3.5876|3.5094|3.479|
3 3/4|6|UN|2A|3 3/4-6 UN 2A|3.750-6 UN 2A|0.0029|3.7471|3.75|3.7289|-|3.6388|3.629|3.5487|-|
3 3/4|6|UN|2B|3 3/4-6 UN 2B|3.750-6 UN 2B|-|-|3.75|3.75|-|3.6544|3.6417|3.6|3.57|
3 3/4|6|UN|3A|3 3/4-6 UN 3A|3.750-6 UN 3A|0|3.75|3.75|3.7318|-|3.6417|3.6344|3.5516|-|
3 3/4|6|UN|3B|3 3/4-6 UN 3B|3.750-6 UN 3B|-|-|3.75|3.75|-|3.6512|3.6417|3.5896|3.57|
3 3/4|8|UN|2A|3 3/4-8 UN 2A|3.750-8 UN 2A|0.0027|3.7473|3.75|3.7323|3.7248|3.6661|3.6571|3.5985|-|
3 3/4|8|UN|2B|3 3/4-8 UN 2B|3.750-8 UN 2B|-|-|3.75|3.75|-|3.6805|3.6688|3.64|3.615|
3 3/4|8|UN|3A|3 3/4-8 UN 3A|3.750-8 UN 3A|0|3.75|3.75|3.735|-|3.6688|3.6621|3.6012|-|
3 3/4|8|UN|3B|3 3/4-8 UN 3B|3.750-8 UN 3B|-|-|3.75|3.75|-|3.6776|3.6688|3.6297|3.615|
3 3/4|10|UNS|2A|3 3/4-10 UNS 2A|3.750-10 UNS 2A|0.0021|3.7479|3.75|3.735|-|3.6829|3.676|3.6289|-|
3 3/4|10|UNS|2B|3 3/4-10 UNS 2B|3.750-10 UNS 2B|-|-|3.75|3.75|-|3.694|3.685|3.663|3.642|
3 3/4|12|UN|2A|3 3/4-12 UN 2A|3.750-12 UN 2A|0.0019|3.7481|3.75|3.7367|-|3.694|3.6876|3.6489|-|
3 3/4|12|UN|2B|3 3/4-12 UN 2B|3.750-12 UN 2B|-|-|3.75|3.75|-|3.7043|3.6959|3.678|3.66|
3 3/4|12|UN|3A|3 3/4-12 UN 3A|3.750-12 UN 3A|0|3.75|3.75|3.7386|-|3.6959|3.6911|3.6508|-|
3 3/4|12|UN|3B|3 3/4-12 UN 3B|3.750-12 UN 3B|-|-|3.75|3.75|-|3.7022|3.6959|3.6698|3.66|
3 3/4|14|UNS|2A|3 3/4-14 UNS 2A|3.750-14 UNS 2A|0.0018|3.7482|3.75|3.7379|-|3.7018|3.6957|3.6632|-|
3 3/4|14|UNS|2B|3 3/4-14 UNS 2B|3.750-14 UNS 2B|-|-|3.75|3.75|-|3.7115|3.7036|3.688|3.673|
3 3/4|16|UN|2A|3 3/4-16 UN 2A|3.750-16 UN 2A|0.0017|3.7483|3.75|3.7389|-|3.7077|3.7019|3.6738|-|
3 3/4|16|UN|2B|3 3/4-16 UN 2B|3.750-16 UN 2B|-|-|3.75|3.75|-|3.7169|3.7094|3.696|3.682|
3 3/4|16|UN|3A|3 3/4-16 UN 3A|3.750-16 UN 3A|0|3.75|3.75|3.7406|-|3.7094|3.7051|3.6755|-|
3 3/4|16|UN|3B|3 3/4-16 UN 3B|3.750-16 UN 3B|-|-|3.75|3.75|-|3.715|3.7094|3.6908|3.682|
3 3/4|18|UNS|2A|3 3/4-18 UNS 2A|3.750-18 UNS 2A|0.0017|3.7483|3.75|3.7396|-|3.7122|3.7067|3.6822|-|
3 3/4|18|UNS|2B|3 3/4-18 UNS 2B|3.750-18 UNS 2B|-|-|3.75|3.75|-|3.7211|3.7139|3.703|3.69|
3 7/8|6|UN|2A|3 7/8-6 UN 2A|3.875-6 UN 2A|0.003|3.872|3.875|3.8538|-|3.7637|3.7538|3.6736|-|
3 7/8|6|UN|2B|3 7/8-6 UN 2B|3.875-6 UN 2B|-|-|3.875|3.875|-|3.7795|3.7667|3.725|3.695|
3 7/8|6|UN|3A|3 7/8-6 UN 3A|3.875-6 UN 3A|0|3.875|3.875|3.8568|-|3.7667|3.7593|3.6766|-|
3 7/8|6|UN|3B|3 7/8-6 UN 3B|3.875-6 UN 3B|-|-|3.875|3.875|-|3.7763|3.7667|3.7146|3.695|
3 7/8|8|UN|2A|3 7/8-8 UN 2A|3.875-8 UN 2A|0.0027|3.8723|3.875|3.8573|-|3.7911|3.782|3.7235|-|
3 7/8|8|UN|2B|3 7/8-8 UN 2B|3.875-8 UN 2B|-|-|3.875|3.875|-|3.8056|3.7938|3.765|3.74|
3 7/8|8|UN|3A|3 7/8-8 UN 3A|3.875-8 UN 3A|0|3.875|3.875|3.86|-|3.7938|3.787|3.7262|-|
3 7/8|8|UN|3B|3 7/8-8 UN 3B|3.875-8 UN 3B|-|-|3.875|3.875|-|3.8026|3.7938|3.7547|3.74|
3 7/8|12|UN|2A|3 7/8-12 UN 2A|3.875-12 UN 2A|0.002|3.873|3.875|3.8616|-|3.8189|3.8124|3.7738|-|
3 7/8|12|UN|2B|3 7/8-12 UN 2B|3.875-12 UN 2B|-|-|3.875|3.875|-|3.8294|3.8209|3.803|3.785|
3 7/8|12|UN|3A|3 7/8-12 UN 3A|3.875-12 UN 3A|0|3.875|3.875|3.8636|-|3.8209|3.816|3.7758|-|
3 7/8|12|UN|3B|3 7/8-12 UN 3B|3.875-12 UN 3B|-|-|3.875|3.875|-|3.8273|3.8209|3.7948|3.785|
3 7/8|16|UN|2A|3 7/8-16 UN 2A|3.875-16 UN 2A|0.0018|3.8732|3.875|3.8638|-|3.8326|3.8267|3.7987|-|
3 7/8|16|UN|2B|3 7/8-16 UN 2B|3.875-16 UN 2B|-|-|3.875|3.875|-|3.842|3.8344|3.821|3.807|
3 7/8|16|UN|3A|3 7/8-16 UN 3A|3.875-16 UN 3A|0|3.875|3.875|3.8656|-|3.8344|3.83|3.8005|-|
3 7/8|16|UN|3B|3 7/8-16 UN 3B|3.875-16 UN 3B|-|-|3.875|3.875|-|3.8401|3.8344|3.8158|3.807|
4|4|UNC|1A|4-4 UNC 1A|4.000-4 UNC 1A|0.0034|3.9966|4|3.9609|-|3.8342|3.8172|3.6989|-|
4|4|UNC|1B|4-4 UNC 1B|4.000-4 UNC 1B|-|-|4|4|-|3.8597|3.8376|3.767|3.729|
4|4|UNC|2A|4-4 UNC 2A|4.000-4 UNC 2A|0.0034|3.9966|4|3.9728|3.9609|3.8342|3.8229|3.6989|-|
4|4|UNC|2B|4-4 UNC 2B|4.000-4 UNC 2B|-|-|4|4|-|3.8523|3.8376|3.767|3.729|
4|4|UNC|3A|4-4 UNC 3A|4.000-4 UNC 3A|0|4|4|3.9762|-|3.8376|3.8291|3.7023|-|
4|4|UNC|3B|4-4 UNC 3B|4.000-4 UNC 3B|-|-|4|4|-|3.8487|3.8376|3.7594|3.729|
4|6|UN|2A|4-6 UN 2A|4.000-6 UN 2A|0.003|3.997|4|3.9788|-|3.8887|3.8788|3.7986|-|
4|6|UN|2B|4-6 UN 2B|4.000-6 UN 2B|-|-|4|4|-|3.9046|3.8917|3.85|3.82|
4|6|UN|3A|4-6 UN 3A|4.000-6 UN 3A|0|4|4|3.9818|-|3.8917|3.8843|3.8016|-|
4|6|UN|3B|4-6 UN 3B|4.000-6 UN 3B|-|-|4|4|-|3.9014|3.8917|3.8396|3.82|
4|8|UN|2A|4-8 UN 2A|4.000-8 UN 2A|0.0027|3.9973|4|3.9823|3.9748|3.9161|3.907|3.8485|-|
4|8|UN|2B|4-8 UN 2B|4.000-8 UN 2B|-|-|4|4|-|3.9307|3.9188|3.89|3.865|
4|8|UN|3A|4-8 UN 3A|4.000-8 UN 3A|0|4|4|3.985|-|3.9188|3.912|3.8512|-|
4|8|UN|3B|4-8 UN 3B|4.000-8 UN 3B|-|-|4|4|-|3.9277|3.9188|3.8797|3.865|
4|10|UNS|2A|4-10 UNS 2A|4.000-10 UNS 2A|0.0021|3.9979|4|3.985|-|3.9329|3.9259|3.8768|-|
4|10|UNS|2B|4-10 UNS 2B|4.000-10 UNS 2B|-|-|4|4|-|3.9441|3.935|3.913|3.892|
4|12|UN|2A|4-12 UN 2A|4.000-12 UN 2A|0.002|3.998|4|3.9866|-|3.9439|3.9374|3.8988|-|
4|12|UN|2B|4-12 UN 2B|4.000-12 UN 2B|-|-|4|4|-|3.9544|3.9459|3.928|3.91|
4|12|UN|3A|4-12 UN 3A|4.000-12 UN 3A|0|4|4|3.9886|-|3.9459|3.941|3.9008|-|
4|12|UN|3B|4-12 UN 3B|4.000-12 UN 3B|-|-|4|4|-|3.9523|3.9459|3.9198|3.91|
4|14|UNS|2A|4-14 UNS 2A|4.000-14 UNS 2A|0.0018|3.9982|4|3.9879|-|3.9518|3.9456|3.9132|-|
4|14|UNS|2B|4-14 UNS 2B|4.000-14 UNS 2B|-|-|4|4|-|3.9616|3.9536|3.938|3.923|
4|16|UN|2A|4-16 UN 2A|4.000-16 UN 2A|0.0018|3.9982|4|3.9888|-|3.9576|3.9517|3.9237|-|
4|16|UN|2B|4-16 UN 2B|4.000-16 UN 2B|-|-|4|4|-|3.967|3.9594|3.946|3.932|
4|16|UN|3A|4-16 UN 3A|4.000-16 UN 3A|0|4|4|3.9906|-|3.9594|3.955|3.9255|-|
4|16|UN|3B|4-16 UN 3B|4.000-16 UN 3B|-|-|4|4|-|3.9651|3.9594|3.9408|3.932|
4 1/4|10|UNS|2A|4 1/4-10 UNS 2A|4.250-10 UNS 2A|0.0021|4.2479|4.25|4.235|-|4.1829|4.1759|4.1289|-|
4 1/4|10|UNS|2B|4 1/4-10 UNS 2B|4.250-10 UNS 2B|-|-|4.25|4.25|-|4.1941|4.185|4.163|4.142|
4 1/4|12|UN|2A|4 1/4-12 UN 2A|4.250-12 UN 2A|0.002|4.248|4.25|4.2366|-|4.1939|4.1874|4.1488|-|
4 1/4|12|UN|2B|4 1/4-12 UN 2B|4.250-12 UN 2B|-|-|4.25|4.25|-|4.2044|4.1959|4.178|4.16|
4 1/4|12|UN|3A|4 1/4-12 UN 3A|4.250-12 UN 3A|0|4.25|4.25|4.2386|-|4.1959|4.191|4.1508|-|
4 1/4|12|UN|3B|4 1/4-12 UN 3B|4.250-12 UN 3B|-|-|4.25|4.25|-|4.2023|4.1959|4.1698|4.16|
4 1/4|14|UNS|2A|4 1/4-14 UNS 2A|4.250-14 UNS 2A|0.0018|4.2482|4.25|4.2379|-|4.2018|4.1956|4.1632|-|
4 1/4|14|UNS|2B|4 1/4-14 UNS 2B|4.250-14 UNS 2B|-|-|4.25|4.25|-|4.2116|4.2036|4.188|4.173|
4 1/4|16|UN|2A|4 1/4-16 UN 2A|4.250-16 UN 2A|0.0018|4.2482|4.25|4.2388|-|4.2076|4.2017|4.1737|-|
4 1/4|16|UN|2B|4 1/4-16 UN 2B|4.250-16 UN 2B|-|-|4.25|4.25|-|4.217|4.2094|4.196|4.182|
4 1/4|16|UN|3A|4 1/4-16 UN 3A|4.250-16 UN 3A|0|4.25|4.25|4.2406|-|4.2094|4.205|4.1755|-|
4 1/4|16|UN|3B|4 1/4-16 UN 3B|4.250-16 UN 3B|-|-|4.25|4.25|-|4.2151|4.2094|4.19|4.182|
4 1/2|10|UNS|2A|4 1/2-10 UNS 2A|4.500-10 UNS 2A|0.0021|4.4979|4.5|4.485|-|4.4329|4.4259|4.3789|-|
4 1/2|10|UNS|2B|4 1/2-10 UNS 2B|4.500-10 UNS 2B|-|-|4.5|4.5|-|4.4441|4.435|4.413|4.392|
4 1/2|12|UN|2A|4 1/2-12 UN 2A|4.500-12 UN 2A|0.002|4.498|4.5|4.4866|-|4.4439|4.4374|4.3988|-|
4 1/2|12|UN|2B|4 1/2-12 UN 2B|4.500-12 UN 2B|-|-|4.5|4.5|-|4.4544|4.4459|4.428|4.41|
4 1/2|12|UN|3A|4 1/2-12 UN 3A|4.500-12 UN 3A|0|4.5|4.5|4.4886|-|4.4459|4.441|4.4008|-|
4 1/2|12|UN|3B|4 1/2-12 UN 3B|4.500-12 UN 3B|-|-|4.5|4.5|-|4.4523|4.4459|4.4198|4.41|
4 1/2|14|UNS|2A|4 1/2-14 UNS 2A|4.500-14 UNS 2A|0.0018|4.4982|4.5|4.4879|-|4.4518|4.4456|4.4132|-|
4 1/2|14|UNS|2B|4 1/2-14 UNS 2B|4.500-14 UNS 2B|-|-|4.5|4.5|-|4.4616|4.4536|4.438|4.423|
4 1/2|16|UN|2A|4 1/2-16 UN 2A|4.500-16 UN 2A|0.0018|4.4982|4.5|4.4888|-|4.4576|4.4517|4.4237|-|
4 1/2|16|UN|2B|4 1/2-16 UN 2B|4.500-16 UN 2B|-|-|4.5|4.5|-|4.467|4.4594|4.446|4.432|
4 1/2|16|UN|3A|4 1/2-16 UN 3A|4.500-16 UN 3A|0|4.5|4.5|4.4906|-|4.4594|4.455|4.4255|-|
4 1/2|16|UN|3B|4 1/2-16 UN 3B|4.500-16 UN 3B|-|-|4.5|4.5|-|4.4651|4.4594|4.4408|4.432|
4 3/4|10|UNS|2A|4 3/4-10 UNS 2A|4.750-10 UNS 2A|0.0022|4.7478|4.75|4.7349|-|4.6828|4.6756|4.6288|-|
4 3/4|10|UNS|2B|4 3/4-10 UNS 2B|4.750-10 UNS 2B|-|-|4.75|4.75|-|4.6944|4.685|4.663|4.642|
4 3/4|12|UN|2A|4 3/4-12 UN 2A|4.750-12 UN 2A|0.002|4.748|4.75|4.7366|-|4.6939|4.6872|4.6488|-|
4 3/4|12|UN|2B|4 3/4-12 UN 2B|4.750-12 UN 2B|-|-|4.75|4.75|-|4.7046|4.6959|4.678|4.66|
4 3/4|12|UN|3A|4 3/4-12 UN 3A|4.750-12 UN 3A|0|4.75|4.75|4.7386|-|4.6959|4.6909|4.6508|-|
4 3/4|12|UN|3B|4 3/4-12 UN 3B|4.750-12 UN 3B|-|-|4.75|4.75|-|4.7025|4.6959|4.6698|4.66|
4 3/4|14|UNS|2A|4 3/4-14 UNS 2A|4.750-14 UNS 2A|0.0019|4.7481|4.75|4.7378|-|4.7017|4.6953|4.6631|-|
4 3/4|14|UNS|2B|4 3/4-14 UNS 2B|4.750-14 UNS 2B|-|-|4.75|4.75|-|4.7119|4.7036|4.688|4.673|
4 3/4|16|UN|2A|4 3/4-16 UN 2A|4.750-16 UN 2A|0.0018|4.7482|4.75|4.7388|-|4.7076|4.7015|4.6737|-|
4 3/4|16|UN|2B|4 3/4-16 UN 2B|4.750-16 UN 2B|-|-|4.75|4.75|-|4.7173|4.7094|4.696|4.682|
4 3/4|16|UN|3A|4 3/4-16 UN 3A|4.750-16 UN 3A|0|4.75|4.75|4.7406|-|4.7094|4.7049|4.6755|-|
4 3/4|16|UN|3B|4 3/4-16 UN 3B|4.750-16 UN 3B|-|-|4.75|4.75|-|4.7153|4.7094|4.6908|4.682|
5|10|UNS|2A|5-10 UNS 2A|5.000-10 UNS 2A|0.0022|4.9978|5|4.9849|-|4.9328|4.9256|4.8788|-|
5|10|UNS|2B|5-10 UNS 2B|5.000-10 UNS 2B|-|-|5|5|-|4.9444|4.935|4.913|4.892|
5|12|UN|2A|5-12 UN 2A|5.000-12 UN 2A|0.002|4.998|5|4.9866|-|4.9439|4.9372|4.8988|-|
5|12|UN|2B|5-12 UN 2B|5.000-12 UN 2B|-|-|5|5|-|4.9546|4.9459|4.928|4.91|
5|12|UN|3A|5-12 UN 3A|5.000-12 UN 3A|0|5|5|4.9886|-|4.9459|4.9409|4.9008|-|
5|12|UN|3B|5-12 UN 3B|5.000-12 UN 3B|-|-|5|5|-|4.9525|4.9459|4.9198|4.91|
5|14|UNS|2A|5-14 UNS 2A|5.000-14 UNS 2A|0.0019|4.9981|5|4.9878|-|4.9517|4.9453|4.9131|-|
5|14|UNS|2B|5-14 UNS 2B|5.000-14 UNS 2B|-|-|5|5|-|4.9619|4.9536|4.938|4.923|
5|16|UN|2A|5-16 UN 2A|5.000-16 UN 2A|0.0018|4.9982|5|4.9888|-|4.9576|4.9515|4.9237|-|
5|16|UN|2B|5-16 UN 2B|5.000-16 UN 2B|-|-|5|5|-|4.9673|4.9594|4.946|4.932|
5|16|UN|3A|5-16 UN 3A|5.000-16 UN 3A|0|5|5|4.9906|-|4.9594|4.9549|4.9255|-|
5|16|UN|3B|5-16 UN 3B|5.000-16 UN 3B|-|-|5|5|-|4.9653|4.9594|4.9408|4.932|
5 1/4|10|UNS|2A|5 1/4-10 UNS 2A|5.250-10 UNS 2A|0.0022|5.2478|5.25|5.2349|-|5.1829|5.1756|5.1288|-|
5 1/4|10|UNS|2B|5 1/4-10 UNS 2B|5.250-10 UNS 2B|-|-|5.25|5.25|-|5.1944|5.185|5.163|5.142|
5 1/4|12|UN|2A|5 1/4-12 UN 2A|5.250-12 UN 2A|0.002|5.248|5.25|5.2366|-|5.1939|5.1872|5.1488|-|
5 1/4|12|UN|2B|5 1/4-12 UN 2B|5.250-12 UN 2B|-|-|5.25|5.25|-|5.2046|5.1959|5.178|5.16|
5 1/4|12|UN|3A|5 1/4-12 UN 3A|5.250-12 UN 3A|0|5.25|5.25|5.2386|-|5.1959|5.1909|5.1508|-|
5 1/4|12|UN|3B|5 1/4-12 UN 3B|5.250-12 UN 3B|-|-|5.25|5.25|-|5.2025|5.1959|5.1698|5.16|
5 1/4|14|UNS|2A|5 1/4-14 UNS 2A|5.250-14 UNS 2A|0.0019|5.2481|5.25|5.2378|-|5.2017|5.1953|5.1631|-|
5 1/4|14|UNS|2B|5 1/4-14 UNS 2B|5.250-14 UNS 2B|-|-|5.25|5.25|-|5.2119|5.2036|5.188|5.173|
5 1/4|16|UN|2A|5 1/4-16 UN 2A|5.250-16 UN 2A|0.0018|5.2482|5.25|5.2388|-|5.2076|5.2015|5.1737|-|
5 1/4|16|UN|2B|5 1/4-16 UN 2B|5.250-16 UN 2B|-|-|5.25|5.25|-|5.2173|5.2094|5.196|5.182|
5 1/4|16|UN|3A|5 1/4-16 UN 3A|5.250-16 UN 3A|0|5.25|5.25|5.2406|-|5.2094|5.2049|5.1755|-|
5 1/4|16|UN|3B|5 1/4-16 UN 3B|5.250-16 UN 3B|-|-|5.25|5.25|-|5.2153|5.2094|5.1908|5.182|
5 1/2|10|UNS|2A|5 1/2-10 UNS 2A|5.500-10 UNS 2A|0.0022|5.4978|5.5|5.4849|-|5.4328|5.4256|5.3788|-|
5 1/2|10|UNS|2B|5 1/2-10 UNS 2B|5.500-10 UNS 2B|-|-|5.5|5.5|-|5.4444|5.435|5.413|5.392|
5 1/2|12|UN|2A|5 1/2-12 UN 2A|5.500-12 UN 2A|0.002|5.498|5.5|5.4866|-|5.4439|5.4372|5.3988|-|
5 1/2|12|UN|2B|5 1/2-12 UN 2B|5.500-12 UN 2B|-|-|5.5|5.5|-|5.4546|5.4459|5.428|5.41|
5 1/2|12|UN|3A|5 1/2-12 UN 3A|5.500-12 UN 3A|0|5.5|5.5|5.4886|-|5.4459|5.4409|5.4008|-|
5 1/2|12|UN|3B|5 1/2-12 UN 3B|5.500-12 UN 3B|-|-|5.5|5.5|-|5.4525|5.4459|5.4198|5.41|
5 1/2|14|UNS|2A|5 1/2-14 UNS 2A|5.500-14 UNS 2A|0.0019|5.4981|5.5|5.4878|-|5.4517|5.4453|5.4131|-|
5 1/2|14|UNS|2B|5 1/2-14 UNS 2B|5.500-14 UNS 2B|-|-|5.5|5.5|-|5.4619|5.4536|5.438|5.423|
5 1/2|16|UN|2A|5 1/2-16 UN 2A|5.500-16 UN 2A|0.0018|5.4982|5.5|5.4888|-|5.4576|5.4515|5.4237|-|
5 1/2|16|UN|2B|5 1/2-16 UN 2B|5.500-16 UN 2B|-|-|5.5|5.5|-|5.4673|5.4594|5.446|5.432|
5 1/2|16|UN|3A|5 1/2-16 UN 3A|5.500-16 UN 3A|0|5.5|5.5|5.4906|-|5.4594|5.4549|5.4255|-|
5 1/2|16|UN|3B|5 1/2-16 UN 3B|5.500-16 UN 3B|-|-|5.5|5.5|-|5.4653|5.4594|5.4408|5.432|
5 3/4|10|UNS|2A|5 3/4-10 UNS 2A|5.750-10 UNS 2A|0.0022|5.7478|5.75|5.7349|-|5.6828|5.6754|5.6288|-|
5 3/4|10|UNS|2B|5 3/4-10 UNS 2B|5.750-10 UNS 2B|-|-|5.75|5.75|-|5.6946|5.685|5.663|5.642|
5 3/4|12|UN|2A|5 3/4-12 UN 2A|5.750-12 UN 2A|0.0021|5.7479|5.75|5.7365|-|5.6938|5.6869|5.6487|-|
5 3/4|12|UN|2B|5 3/4-12 UN 2B|5.750-12 UN 2B|-|-|5.75|5.75|-|5.7049|5.6959|5.678|5.66|
5 3/4|12|UN|3A|5 3/4-12 UN 3A|5.750-12 UN 3A|0|5.75|5.75|5.7386|-|5.6959|5.6907|5.6508|-|
5 3/4|12|UN|3B|5 3/4-12 UN 3B|5.750-12 UN 3B|-|-|5.75|5.75|-|5.7026|5.6959|5.6698|5.66|
5 3/4|14|UNS|2A|5 3/4-14 UNS 2A|5.750-14 UNS 2A|0.002|5.748|5.75|5.7377|-|5.7016|5.6951|5.663|-|
5 3/4|14|UNS|2B|5 3/4-14 UNS 2B|5.750-14 UNS 2B|-|-|5.75|5.75|-|5.7121|5.7036|5.688|5.673|
5 3/4|16|UN|2A|5 3/4-16 UN 2A|5.750-16 UN 2A|0.0019|5.7481|5.75|5.7387|-|5.7075|5.7013|5.6736|-|
5 3/4|16|UN|2B|5 3/4-16 UN 2B|5.750-16 UN 2B|-|-|5.75|5.75|-|5.7175|5.7094|5.696|5.682|
5 3/4|16|UN|3A|5 3/4-16 UN 3A|5.750-16 UN 3A|0|5.75|5.75|5.7406|-|5.7094|5.7047|5.6755|-|
5 3/4|16|UN|3B|5 3/4-16 UN 3B|5.750-16 UN 3B|-|-|5.75|5.75|-|5.7155|5.7094|5.6908|5.682|
6|10|UNS|2A|6-10 UNS 2A|6.000-10 UNS 2A|0.0022|5.9978|6|5.9849|-|5.9328|5.9254|5.8788|-|
6|10|UNS|2B|6-10 UNS 2B|6.000-10 UNS 2B|-|-|6|6|-|5.9446|5.935|5.913|5.892|
6|12|UN|2A|6-12 UN 2A|6.000-12 UN 2A|0.0021|5.9979|6|5.9865|-|5.9438|5.9369|5.8987|-|
6|12|UN|2B|6-12 UN 2B|6.000-12 UN 2B|-|-|6|6|-|5.9549|5.9459|5.928|5.91|
6|12|UN|3A|6-12 UN 3A|6.000-12 UN 3A|0|6|6|5.9886|-|5.9459|5.9407|5.9008|-|
6|12|UN|3B|6-12 UN 3B|6.000-12 UN 3B|-|-|6|6|-|5.9526|5.9459|5.9198|5.91|
6|14|UNS|2A|6-14 UNS 2A|6.000-14 UNS 2A|0.002|5.998|6|5.9877|-|5.9516|5.9451|5.913|-|
6|14|UNS|2B|6-14 UNS 2B|6.000-14 UNS 2B|-|-|6|6|-|5.9621|5.9536|5.938|5.923|
6|16|UN|2A|6-16 UN 2A|6.000-16 UN 2A|0.0019|5.9981|6|5.9887|-|5.9575|5.9513|5.9236|-|
6|16|UN|2B|6-16 UN 2B|6.000-16 UN 2B|-|-|6|6|-|5.9675|5.9594|5.946|5.932|
6|16|UN|3A|6-16 UN 3A|6.000-16 UN 3A|0|6|6|5.9906|-|5.9594|5.9547|5.9255|-|
6|16|UN|3B|6-16 UN 3B|6.000-16 UN 3B|-|-|6|6|-|5.9655|5.9594|5.9408|5.932|
-|0.35|M|4g6g|-|M1.6 X 0.35-4g6g|0.0190|1.581|1.6|1.496|-|1.354|1.314|1.202|1.098|0.04
-|0.35|M|6g|-|M1.6 X 0.35-6g|0.0190|1.581|1.6|1.496|-|1.354|1.291|1.202|1.075|0.063
-|0.35|M|6H|-|M1.6 X 0.35-6H|-|1.736|1.6|1.6|-|1.458|1.373|1.321|1.221|0.085
-|0.4|M|4g6g|-|M2 X 0.4-4g6g|0.0190|1.981|2|1.886|-|1.721|1.679|1.548|1.433|0.042
-|0.4|M|6g|-|M2 X 0.4-6g|0.0190|1.981|2|1.886|-|1.721|1.654|1.548|1.408|0.067
-|0.4|M|6H|-|M2 X 0.4-6H|-|2.148|2|2|-|1.83|1.74|1.679|1.567|0.09
-|0.45|M|4g6g|-|M2.5 X 0.45-4g6g|0.0200|2.48|2.5|2.38|-|2.188|2.143|1.993|1.866|0.045
-|0.45|M|6g|-|M2.5 X 0.45-6g|0.0200|2.48|2.5|2.38|-|2.188|2.117|1.993|1.84|0.071
-|0.45|M|6H|-|M2.5 X 0.45-6H|-|2.66|2.5|2.5|-|2.303|2.208|2.138|2.013|0.095
-|0.5|M|4g6g|-|M3 X 0.5-4g6g|0.0200|2.98|3|2.874|-|2.655|2.607|2.439|2.299|0.048
-|0.5|M|6g|-|M3 X 0.5-6g|0.0200|2.98|3|2.874|-|2.655|2.58|2.439|2.272|0.075
-|0.5|M|6H|-|M3 X 0.5-6H|-|3.172|3|3|-|2.775|2.675|2.599|2.459|0.1
-|0.6|M|4g6g|-|M3.5 X 0.6-4g6g|0.0210|3.479|3.5|3.354|-|3.089|3.036|2.829|2.667|0.053
-|0.6|M|6g|-|M3.5 X 0.6-6g|0.0210|3.479|3.5|3.354|-|3.089|3.004|2.829|2.635|0.085
-|0.6|M|6H|-|M3.5 X 0.6-6H|-|3.699|3.5|3.5|-|3.222|3.11|3.01|2.85|0.112
-|0.7|M|4g6g|-|M4 X 0.7-4g6g|0.0220|3.978|4|3.838|-|3.523|3.467|3.22|3.036|0.056
-|0.7|M|6g|-|M4 X 0.7-6g|0.0220|3.978|4|3.838|-|3.523|3.433|3.22|3.002|0.09
-|0.7|M|6H|-|M4 X 0.7-6H|-|4.219|4|4|-|3.663|3.545|3.422|3.242|0.118
-|0.8|M|4g6g|-|M5 X 0.8-4g6g|0.0240|4.976|5|4.826|-|4.456|4.396|4.11|3.904|0.06
-|0.8|M|6g|-|M5 X 0.8-6g|0.0240|4.976|5|4.826|-|4.456|4.361|4.11|3.869|0.095
-|0.8|M|6H|-|M5 X 0.8-6H|-|5.24|5|5|-|4.605|4.48|4.334|4.134|0.125
-|1|M|4g6g|-|M6 X 1-4g6g|0.0260|5.974|6|5.794|-|5.324|5.253|4.891|4.637|0.071
-|1|M|6g|-|M6 X 1-6g|0.0260|5.974|6|5.794|-|5.324|5.212|4.891|4.596|0.112
-|1|M|6H|-|M6 X 1-6H|-|6.294|6|6|-|5.5|5.35|5.153|4.917|0.15
-|1.25|M|4g6g|-|M8 X 1.25-4g6g|0.0280|7.972|8|7.76|-|7.16|7.085|6.619|6.315|0.075
-|1.25|M|6g|-|M8 X 1.25-6g|0.0280|7.972|8|7.76|-|7.16|7.042|6.619|6.272|0.118
-|1.25|M|6H|-|M8 X 1.25-6H|-|8.34|8|8|-|7.348|7.188|6.912|6.647|0.16
-|1|M|4g6g|-|M8 X 1-4g6g|0.0260|7.974|8|7.794|-|7.324|7.253|6.891|6.637|0.071
-|1|M|6g|-|M8 X 1-6g|0.0260|7.974|8|7.794|-|7.324|7.212|6.891|6.596|0.112
-|1|M|6H|-|M8 X 1-6H|-|8.294|8|8|-|7.5|7.35|7.153|6.917|0.15
-|0.75|M|4g6g|-|M10 X 0.75-4g6g|0.0220|9.978|10|9.838|-|9.491|9.428|9.166|8.966|0.063
-|0.75|M|6g|-|M10 X 0.75-6g|0.0220|9.978|10|9.838|-|9.491|9.391|9.166|8.929|0.1
-|0.75|M|6H|-|M10 X 0.75-6H|-|10.24|10|10|-|9.645|9.513|9.378|9.188|0.132
-|1.25|M|4g6g|-|M10 X 1.25-4g6g|0.0280|9.972|10|9.76|-|9.16|9.085|8.619|8.315|0.075
-|1.25|M|6g|-|M10 X 1.25-6g|0.0280|9.972|10|9.76|-|9.16|9.042|8.619|8.272|0.118
-|1.25|M|6H|-|M10 X 1.25-6H|-|10.34|10|10|-|9.348|9.188|8.912|8.647|0.16
-|1.5|M|4g6g|-|M10 X 1.5-4g6g|0.0320|9.968|10|9.732|-|8.994|8.909|8.344|7.985|0.085
-|1.5|M|6g|-|M10 X 1.5-6g|0.0320|9.968|10|9.732|-|8.994|8.862|8.344|7.938|0.132
-|1.5|M|6H|-|M10 X 1.5-6H|-|10.396|10|10|-|9.206|9.026|8.676|8.376|0.18
-|1.25|M|4g6g|-|M12 X 1.25-4g6g|0.0280|11.972|12|11.76|-|11.16|11.075|10.619|10.305|0.085
-|1.25|M|6g|-|M12 X 1.25-6g|0.0280|11.972|12|11.76|-|11.16|11.028|10.619|10.258|0.132
-|1.25|M|6H|-|M12 X 1.25-6H|-|12.36|12|12|-|11.368|11.188|10.912|10.647|0.18
-|1.5|M|6g|-|M12 X 1.5-6g|0.0320|11.968|12|11.732|-|10.994|10.854|10.344|9.93|0.14
-|1.5|M|6H|-|M12 X 1.5-6H|-|12.406|12|12|-|11.216|11.026|10.676|10.376|0.19
-|1.75|M|4g6g|-|M12 X 1.75-4g6g|0.0340|11.966|12|11.701|-|10.829|10.734|10.072|9.656|0.095
-|1.75|M|6g|-|M12 X 1.75-6g|0.0340|11.966|12|11.701|-|10.829|10.679|10.072|9.601|0.15
-|1.75|M|6H|-|M12 X 1.75-6H|-|12.453|12|12|-|11.063|10.863|10.441|10.106|0.2
-|1|M|4g6g|-|M12 X 1-4g6g|0.0260|11.974|12|11.794|-|11.324|11.249|10.891|10.633|0.075
-|1|M|6g|-|M12 X 1-6g|0.0260|11.974|12|11.794|-|11.324|11.206|10.891|10.59|0.118
-|1|M|6H|-|M12 X 1-6H|-|12.304|12|12|-|11.51|11.35|11.153|10.917|0.16
-|1.5|M|4g6g|-|M14 X 1.5-4g6g|0.0320|13.968|14|13.732|-|12.994|12.904|12.344|11.98|0.09
-|1.5|M|6g|-|M14 X 1.5-6g|0.0320|13.968|14|13.732|-|12.994|12.854|12.344|11.93|0.14
-|1.5|M|6H|-|M14 X 1.5-6H|-|14.406|14|14|-|13.216|13.026|12.676|12.376|0.19
-|2|M|4g6g|-|M14 X 2-4g6g|0.0380|13.962|14|13.682|-|12.663|12.563|11.797|11.331|0.1
-|2|M|6g|-|M14 X 2-6g|0.0380|13.962|14|13.682|-|12.663|12.503|11.797|11.271|0.16
-|2|M|6H|-|M14 X 2-6H|-|14.501|14|14|-|12.913|12.701|12.21|11.835|0.212
-|1|M|4g6g|-|M15 X 1-4g6g|0.0260|14.974|15|14.794|-|14.324|14.249|13.891|13.633|0.075
-|1|M|6g|-|M15 X 1-6g|0.0260|14.974|15|14.794|-|14.324|14.206|13.891|13.59|0.118
-|1|M|6H|-|M15 X 1-6H|-|15.304|15|15|-|14.51|14.35|14.153|13.917|0.16
-|1.5|M|4g6g|-|M16 X 1.5-4g6g|0.0320|15.968|16|15.732|-|14.994|14.904|14.344|13.98|0.09
-|1.5|M|6g|-|M16 X 1.5-6g|0.0320|15.968|16|15.732|-|14.994|14.854|14.344|13.93|0.14
-|1.5|M|6H|-|M16 X 1.5-6H|-|16.406|16|16|-|15.216|15.026|14.676|14.376|0.19
-|2|M|4g6g|-|M16 X 2-4g6g|0.0380|15.962|16|15.682|-|14.663|14.563|13.797|13.331|0.1
-|2|M|6g|-|M16 X 2-6g|0.0380|15.962|16|15.682|-|14.663|14.503|13.797|13.271|0.16
-|2|M|6H|-|M16 X 2-6H|-|16.501|16|16|-|14.913|14.701|14.21|13.835|0.212
-|1|M|4g6g|-|M17 X 1-4g6g|0.0260|16.974|17|16.794|-|16.324|16.249|15.891|15.633|0.075
-|1|M|6g|-|M17 X 1-6g|0.0260|16.974|17|16.794|-|16.324|16.206|15.891|15.59|0.118
-|1|M|6H|-|M17 X 1-6H|-|17.304|17|17|-|16.51|16.35|16.153|15.917|0.16
-|1.5|M|4g6g|-|M18 X 1.5-4g6g|0.0320|17.968|18|17.732|-|16.994|16.904|16.344|15.98|0.09
-|1.5|M|6g|-|M18 X 1.5-6g|0.0320|17.968|18|17.732|-|16.994|16.854|16.344|15.93|0.14
-|1.5|M|6H|-|M18 X 1.5-6H|-|18.406|18|18|-|17.216|17.026|16.676|16.376|0.19
-|1.5|M|4g6g|-|M20 X 1.5-4g6g|0.0320|19.968|20|19.732|-|18.994|18.904|18.344|17.98|0.09
-|1.5|M|6g|-|M20 X 1.5-6g|0.0320|19.968|20|19.732|-|18.994|18.854|18.344|17.93|0.14
-|1.5|M|6H|-|M20 X 1.5-6H|-|20.406|20|20|-|19.216|19.026|18.676|18.376|0.19
-|1|M|4g6g|-|M20 X 1-4g6g|0.0260|19.974|20|19.794|-|19.324|19.249|18.891|18.633|0.075
-|1|M|6g|-|M20 X 1-6g|0.0260|19.974|20|19.794|-|19.324|19.206|18.891|18.59|0.118
-|1|M|6H|-|M20 X 1-6H|-|20.304|20|20|-|19.51|19.35|19.153|18.917|0.16
-|2.5|M|4g6g|-|M20 X 2.5-4g6g|0.0420|19.958|20|19.623|-|18.334|18.228|17.252|16.688|0.106
-|2.5|M|6g|-|M20 X 2.5-6g|0.0420|19.958|20|19.623|-|18.334|18.164|17.252|16.624|0.17
-|2.5|M|6H|-|M20 X 2.5-6H|-|20.585|20|20|-|18.6|18.376|17.744|17.294|0.224
-|1.5|M|4g6g|-|M22 X 1.5-4g6g|0.0320|21.968|22|21.732|-|20.994|20.904|20.344|19.98|0.09
-|1.5|M|6g|-|M22 X 1.5-6g|0.0320|21.968|22|21.732|-|20.994|20.854|20.344|19.93|0.14
-|1.5|M|6H|-|M22 X 1.5-6H|-|22.406|22|22|-|21.216|21.026|20.676|20.376|0.19
-|2.5|M|6g|-|M22 X 2.5-6g|0.0420|21.9587|22|21.623|-|20.334|20.164|19.252|18.624|0.17
-|2.5|M|6H|-|M22 X 2.5-6H|-|22.585|22|22|-|20.6|20.376|19.744|19.294|0.224
-|2|M|4g6g|-|M24 X 2-4g6g|0.0380|23.962|24|23.682|-|22.663|22.557|21.797|21.325|0.106
-|2|M|6g|-|M24 X 2-6g|0.0380|23.962|24|23.682|-|22.663|22.493|21.797|21.261|0.17
-|2|M|6H|-|M24 X 2-6H|-|24.513|24|24|-|22.925|22.701|22.21|21.835|0.224
-|3|M|4g6g|-|M24 X 3-4g6g|0.0480|23.952|24|23.557|-|22.003|21.878|20.704|20.03|0.125
-|3|M|6g|-|M24 X 3-6g|0.0480|23.952|24|23.577|-|22.003|21.803|20.704|19.955|0.2
-|3|M|6H|-|M24 X 3-6H|-|24.698|24|24|-|22.316|22.051|21.252|20.752|0.265
-|1.5|M|4g6g|-|M25 X 1.5-4g6g|0.0320|24.968|25|24.732|-|23.994|23.899|23.344|22.975|0.095
-|1.5|M|6g|-|M25 X 1.5-6g|0.0320|24.968|25|24.732|-|23.994|23.844|23.344|22.92|0.15
-|1.5|M|6H|-|M25 X 1.5-6H|-|25.416|25|25|-|24.226|24.026|23.676|23.376|0.2
-|2|M|4g6g|-|M27 X 2-4g6g|0.0380|26.962|27|26.682|-|25.663|25.557|24.797|24.325|0.106
-|2|M|6g|-|M27 X 2-6g|0.0380|26.962|27|26.682|-|25.663|25.493|24.797|24.261|0.17
-|2|M|6H|-|M27 X 2-6H|-|27.513|27|27|-|25.925|25.701|25.21|24.835|0.224
-|3|M|6g|-|M27 X 3-6g|0.0480|26.952|27|26.577|-|25.003|24.803|23.704|22.955|0.2
-|3|M|6H|-|M27 X 3-6H|-|27.698|27|27|-|25.316|25.051|24.252|23.752|0.265
-|1.5|M|4g6g|-|M30 X 1.5-4g6g|0.0320|29.968|30|29.732|-|28.994|28.899|28.344|27.975|0.095
-|1.5|M|6g|-|M30 X 1.5-6g|0.0320|29.968|30|29.732|-|28.994|28.844|28.344|27.92|0.15
-|1.5|M|6H|-|M30 X 1.5-6H|-|30.416|30|30|-|29.226|29.026|28.676|28.376|0.2
-|2|M|4g6g|-|M30 X 2-4g6g|0.0380|29.962|30|29.682|-|28.663|28.557|27.797|27.325|0.106
-|2|M|6g|-|M30 X 2-6g|0.0380|29.962|30|29.682|-|28.663|28.493|27.797|27.261|0.17
-|2|M|6H|-|M30 X 2-6H|-|30.513|30|30|-|28.925|28.701|28.21|27.835|0.224
-|3.5|M|4g6g|-|M30 X 3.5-4g6g|0.0530|29.947|30|29.522|-|27.674|27.542|26.158|25.386|0.132
-|3.5|M|6g|-|M30 X 3.5-6g|0.0530|29.947|30|29.522|-|27.674|27.462|26.158|25.306|0.212
-|3.5|M|6H|-|M30 X 3.5-6H|-|30.785|30|30|-|28.007|27.727|26.771|26.211|0.28
-|2|M|4g6g|-|M33 X 2-4g6g|0.0380|32.962|33|32.682|-|31.663|31.557|30.797|30.325|0.106
-|2|M|6g|-|M33 X 2-6g|0.0380|32.962|33|32.682|-|31.663|31.493|30.797|30.261|0.17
-|2|M|6H|-|M33 X 2-6H|-|33.513|33|33|-|31.925|31.701|31.21|30.835|0.224
-|1.5|M|6g|-|M35 X 1.5-6g|0.0320|34.968|35|34.732|-|33.994|33.844|33.344|33.92|0.15
-|1.5|M|6H|-|M35 X 1.5-6H|-|35.416|35|35|-|34.226|34.026|33.676|33.376|0.2
-|2|M|4g6g|-|M36 X 2-4g6g|0.0380|35.962|36|35.682|-|34.663|34.557|33.797|33.325|0.106
-|2|M|6g|-|M36 X 2-6g|0.0380|35.962|36|35.682|-|34.663|34.493|33.797|33.261|0.17
-|2|M|6H|-|M36 X 2-6H|-|36.513|36|36|-|34.925|34.701|34.21|33.835|0.224
-|4|M|4g6g|-|M36 X 4-4g6g|0.0600|35.94|36|35.465|-|33.342|33.202|31.61|30.738|0.14
-|4|M|6g|-|M36 X 4-6g|0.0600|35.94|36|35.465|-|33.342|33.118|31.61|30.654|0.224
-|4|M|6H|-|M36 X 4-6H|-|36.877|36|36|-|33.702|33.402|32.27|31.67|0.3
-|2|M|4g6g|-|M39 X 2-4g6g|0.0380|38.962|39|38.682|-|37.663|37.557|36.797|36.325|0.106
-|2|M|6g|-|M39 X 2-6g|0.0380|38.962|39|38.682|-|37.663|37.493|36.797|36.261|0.17
-|2|M|6H|-|M39 X 2-6H|-|39.513|39|39|-|37.925|37.701|37.21|36.835|0.224
-|1.5|M|4g6g|-|M40 X 1.5-4g6g|0.0320|39.968|40|39.732|-|38.994|38.899|38.344|37.975|0.095
-|1.5|M|6g|-|M40 X 1.5-6g|0.0320|39.968|40|39.732|-|38.994|38.844|38.344|37.92|0.15
-|1.5|M|6H|-|M40 X 1.5-6H|-|40.416|40|40|-|39.226|39.026|38.676|38.376|0.2
-|2|M|4g6g|-|M42 X 2-4g6g|0.0380|41.962|42|41.682|-|40.663|40.557|39.797|39.325|0.106
-|2|M|6g|-|M42 X 2-6g|0.0380|41.962|42|41.682|-|40.663|40.493|39.797|39.261|0.17
-|2|M|6H|-|M42 X 2-6H|-|42.513|42|42|-|40.925|40.701|40.21|39.835|0.224
-|4.5|M|4g6g|-|M42 X 4.5-4g6g|0.0630|41.937|42|41.437|-|39.014|38.864|37.066|36.092|0.15
-|4.5|M|6g|-|M42 X 4.5-6g|0.0630|41.937|42|41.437|-|39.014|38.778|37.066|36.006|0.236
-|4.5|M|6H|-|M42 X 4.5-6H|-|42.965|42|42|-|39.392|39.077|37.799|37.129|0.315
-|1.5|M|4g6g|-|M45 X 1.5-4g6g|0.0320|44.968|45|44.732|-|43.994|43.899|43.344|42.975|0.095
-|1.5|M|6g|-|M45 X 1.5-6g|0.0320|44.968|45|44.732|-|43.994|43.844|43.344|42.92|0.15
-|1.5|M|6H|-|M45 X 1.5-6H|-|45.416|45|45|-|44.226|44.026|43.676|43.376|0.2
-|2|M|4g6g|-|M48 X 2-4g6g|0.0380|47.962|48|47.682|-|46.663|46.551|45.797|45.319|0.112
-|2|M|6g|-|M48 X 2-6g|0.0380|47.962|48|47.682|-|46.663|46.483|45.797|45.251|0.18
-|2|M|6H|-|M48 X 2-6H|-|48.525|48|48|-|46.937|46.701|46.21|45.835|0.236
-|5|M|4g6g|-|M48 X 5-4g6g|0.0710|47.929|48|47.399|-|44.681|44.521|42.516|41.441|0.16
-|5|M|6g|-|M48 X 5-6g|0.0710|47.929|48|47.399|-|44.681|44.431|42.516|41.351|0.25
-|5|M|6H|-|M48 X 5-6H|-|49.057|48|48|-|45.087|44.752|43.297|42.587|0.335
-|1.5|M|4g6g|-|M50 X 1.5-4g6g|0.0320|49.968|50|49.732|-|48.994|48.894|48.344|47.97|0.1
-|1.5|M|6g|-|M50 X 1.5-6g|0.0320|49.968|50|49.732|-|48.994|48.834|48.344|47.91|0.16
-|1.5|M|6H|-|M50 X 1.5-6H|-|50.428|50|50|-|49.238|49.026|48.676|48.376|0.212
-|1.5|M|4g6g|-|M55 X 1.5-4g6g|0.0320|54.968|55|54.732|-|53.994|53.894|53.344|52.97|0.1
-|1.5|M|6g|-|M55 X 1.5-6g|0.0320|54.968|55|54.732|-|53.994|53.834|53.344|52.91|0.16
-|1.5|M|6H|-|M55 X 1.5-6H|-|55.428|55|55|-|54.238|54.026|53.676|53.376|0.212
-|2|M|4g6g|-|M56 X 2-4g6g|0.0380|55.962|56|55.682|-|54.663|54.551|53.797|53.319|0.112
-|2|M|6g|-|M56 X 2-6g|0.0380|55.962|56|55.682|-|54.663|54.483|53.797|53.251|0.18
-|2|M|6H|-|M56 X 2-6H|-|56.525|56|56|-|54.937|54.701|54.21|53.835|0.236
-|5.5|M|4g6g|-|M56 X 5.5-4g6g|0.0750|55.925|56|55.365|-|52.353|52.183|49.971|48.795|0.17
-|5.5|M|6g|-|M56 X 5.5-6g|0.0750|55.925|56|55.365|-|52.353|52.088|49.971|48.7|0.265
-|5.5|M|6H|-|M56 X 5.5-6H|-|57.149|56|56|-|52.783|52.428|50.796|50.046|0.355
-|1.5|M|4g6g|-|M60 X 1.5-4g6g|0.0320|59.968|60|59.732|-|58.994|58.894|58.344|57.97|0.1
-|1.5|M|6g|-|M60 X 1.5-6g|0.0320|59.968|60|59.732|-|58.994|58.834|58.344|57.91|0.16
-|1.5|M|6H|-|M60 X 1.5-6H|-|60.428|60|60|-|59.238|59.026|58.676|58.376|0.212
-|2|M|4g6g|-|M64 X 2-4g6g|0.0380|63.962|64|63.682|-|62.663|62.551|61.797|61.319|0.112
-|2|M|6g|-|M64 X 2-6g|0.0380|63.962|64|63.682|-|62.663|62.483|61.797|61.251|0.18
-|2|M|6H|-|M64 X 2-6H|-|64.525|64|64|-|62.937|62.701|62.21|61.835|0.236
-|6|M|4g6g|-|M64 X 6-4g6g|0.0800|63.92|64|63.32|-|60.023|59.843|57.425|56.147|0.18
-|6|M|6g|-|M64 X 6-6g|0.0800|63.92|64|63.32|-|60.023|59.743|57.425|56.047|0.28
-|6|M|6H|-|M64 X 6-6H|-|65.241|64|64|-|60.478|60.103|58.305|57.505|0.375
-|1.5|M|4g6g|-|M65 X 1.5-4g6g|0.0320|64.968|65|64.732|-|63.994|63.894|63.344|62.97|0.1
-|1.5|M|6g|-|M65 X 1.5-6g|0.0320|64.968|65|64.732|-|63.994|63.834|63.344|62.91|0.16
-|1.5|M|6H|-|M65 X 1.5-6H|-|65.428|65|65|-|64.238|64.026|63.676|63.376|0.212
-|1.5|M|4g6g|-|M70 X 1.5-4g6g|0.0320|69.968|70|69.732|-|68.994|68.894|68.344|67.97|0.1
-|1.5|M|6g|-|M70 X 1.5-6g|0.0320|69.968|70|69.732|-|68.994|68.834|68.344|67.91|0.16
-|1.5|M|6H|-|M70 X 1.5-6H|-|70.428|70|70|-|69.238|69.026|68.676|68.376|0.212
-|2|M|4g6g|-|M72 X 2-4g6g|0.0380|71.962|72|71.682|-|70.663|70.551|69.797|69.319|0.112
-|2|M|6g|-|M72 X 2-6g|0.0380|71.962|72|71.682|-|70.663|70.483|69.797|69.251|0.18
-|2|M|6H|-|M72 X 2-6H|-|72.525|72|72|-|70.937|70.701|70.21|69.835|0.236
-|6|M|4g6g|-|M72 X 6-4g6g|0.0800|71.92|72|71.32|-|68.023|67.843|65.425|64.147|0.18
-|6|M|6g|-|M72 X 6-6g|0.0800|71.92|72|71.32|-|68.023|67.743|65.425|64.047|0.28
-|6|M|6H|-|M72 X 6-6H|-|73.241|72|72|-|68.478|68.103|66.305|65.505|0.375
-|1.5|M|4g6g|-|M75 X 1.5-4g6g|0.0320|74.968|75|74.732|-|73.994|73.894|73.344|72.97|0.1
-|1.5|M|6g|-|M75 X 1.5-6g|0.0320|74.968|75|74.732|-|73.994|73.834|73.344|72.91|0.16
-|1.5|M|6H|-|M75 X 1.5-6H|-|75.428|75|75|-|74.238|74.026|73.676|73.376|0.212
-|1.5|M|4g6g|-|M80 X 1.5-4g6g|0.0320|79.968|80|79.732|-|78.994|78.894|78.334|77.97|0.1
-|1.5|M|6g|-|M80 X 1.5-6g|0.0320|79.968|80|79.732|-|78.994|78.834|78.344|77.91|0.16
-|1.5|M|6H|-|M80 X 1.5-6H|-|80.428|80|80|-|79.238|79.026|78.676|78.376|0.212
-|2|M|4g6g|-|M80 X 2-4g6g|0.0380|79.962|80|79.682|-|78.663|78.551|77.797|77.319|0.112
-|2|M|6g|-|M80 X 2-6g|0.0380|79.962|80|79.682|-|78.663|78.483|77.797|77.251|0.18
-|2|M|6H|-|M80 X 2-6H|-|80.525|80|80|-|78.937|78.701|78.21|77.835|0.236
-|6|M|4g6g|-|M80 X 6-4g6g|0.0800|79.92|80|79.32|-|76.023|75.843|73.425|72.147|0.18
-|6|M|6g|-|M80 X 6-6g|0.0800|79.92|80|79.32|-|76.023|75.743|73.425|72.047|0.28
-|6|M|6H|-|M80 X 6-6H|-|81.241|80|80|-|76.478|76.103|74.305|73.505|0.375
-|2|M|4g6g|-|M85 X 2-4g6g|0.0380|84.962|85|84.682|-|83.663|83.551|82.797|82.319|0.112
-|2|M|6g|-|M85 X 2-6g|0.0380|84.962|85|84.682|-|83.663|83.483|82.797|82.251|0.18
-|2|M|6H|-|M85 X 2-6H|-|85.525|85|85|-|83.937|83.701|83.21|82.835|0.236
-|2|M|4g6g|-|M90 X 2-4g6g|0.0380|89.962|90|89.682|-|88.663|88.551|87.797|87.319|0.112
-|2|M|6g|-|M90 X 2-6g|0.0380|89.962|90|89.682|-|88.663|88.483|87.797|87.251|0.18
-|2|M|6H|-|M90 X 2-6H|-|90.525|90|90|-|88.937|88.701|88.21|87.835|0.236
-|6|M|4g6g|-|M90 X 6-4g6g|0.0800|89.92|90|89.32|-|86.023|85.843|83.425|82.147|0.18
-|6|M|6g|-|M90 X 6-6g|0.0800|89.92|90|89.32|-|86.023|85.743|83.425|82.047|0.28
-|6|M|6H|-|M90 X 6-6H|-|91.241|90|90|-|86.478|86.103|84.305|83.505|0.375
-|2|M|4g6g|-|M95 X 2-4g6g|0.0380|94.962|95|94.682|-|93.663|93.545|92.797|92.313|0.118
-|2|M|6g|-|M95 X 2-6g|0.0380|94.962|95|94.682|-|93.663|93.473|92.797|92.241|0.19
-|2|M|6H|-|M95 X 2-6H|-|95.539|95|95|-|93.951|93.701|93.21|92.835|0.25
-|2|M|4g6g|-|M100 X 2-4g6g|0.0380|99.962|100|99.682|-|98.663|98.545|97.797|97.313|0.118
-|2|M|6g|-|M100 X 2-6g|0.0380|99.962|100|99.682|-|98.663|98.473|97.797|97.241|0.19
-|2|M|6H|-|M100 X 2-6H|-|100.539|100|100|-|98.951|98.701|98.21|97.835|0.25
-|6|M|4g6g|-|M100 X 6-4g6g|0.0800|99.92|100|99.32|-|96.023|95.833|93.425|92.137|0.19
-|6|M|6g|-|M100 X 6-6g|0.0800|99.92|100|99.32|-|96.023|95.723|93.425|92.027|0.3
-|6|M|6H|-|M100 X 6-6H|-|101.266|100|100|-|96.503|96.103|94.305|93.505|0.4
-|2|M|4g6g|-|M105 X 2-4g6g|0.0380|104.962|105|104.682|-|103.663|103.545|102.797|102.313|0.118
-|2|M|6g|-|M105 X 2-6g|0.0380|104.962|105|104.682|-|103.663|103.473|102.797|102.241|0.19
-|2|M|6H|-|M105 X 2-6H|-|105.539|105|105|-|103.951|103.701|103.21|102.835|0.25
-|2|M|4g6g|-|M110 X 2-4g6g|0.0380|109.962|110|109.682|-|108.663|108.545|107.797|107.313|0.118
-|2|M|6g|-|M110 X 2-6g|0.0380|109.962|110|109.682|-|108.663|108.473|107.797|107.241|0.19
-|2|M|6H|-|M110 X 2-6H|-|110.539|110|110|-|108.951|108.701|108.21|107.835|0.25
-|2|M|4g6g|-|M120 X 2-4g6g|0.0380|119.962|120|119.682|-|118.663|118.545|117.797|117.313|0.118
-|2|M|6g|-|M120 X 2-6g|0.0380|119.962|120|119.682|-|118.663|118.473|117.797|117.241|0.19
-|2|M|6H|-|M120 X 2-6H|-|120.539|120|120|-|118.951|118.701|118.21|117.835|0.25
-|2|M|4g6g|-|M130 X 2-4g6g|0.0380|139.962|130|139.682|-|138.663|138.545|137.797|137.313|0.118
-|2|M|6g|-|M130 X 2-6g|0.0380|129.962|130|129.682|-|128.663|128.473|127.797|127.241|0.19
-|2|M|6H|-|M130 X 2-6H|-|130.539|130|130|-|128.951|128.701|128.21|127.835|0.25
-|2|M|4g6g|-|M140 X 2-4g6g|0.0380|139.962|140|139.682|-|138.663|138.545|137.797|137.313|0.118
-|2|M|6g|-|M140 X 2-6g|0.0380|139.962|140|139.682|-|138.663|138.473|137.797|137.241|0.19
-|2|M|6H|-|M140 X 2-6H|-|140.539|140|140|-|138.951|138.701|138.21|137.835|0.25
-|2|M|4g6g|-|M150 X 2-4g6g|0.0380|149.962|150|149.682|-|148.663|148.545|147.797|147.313|0.118
-|2|M|6g|-|M150 X 2-6g|0.0380|149.962|150|149.682|-|148.663|148.473|147.797|147.241|0.19
-|2|M|6H|-|M150 X 2-6H|-|150.539|150|150|-|148.951|148.701|148.21|147.835|0.25
-|3|M|4g6g|-|M160 X 3-4g6g|0.0480|159.952|160|159.577|-|158.003|157.863|156.704|156.015|0.14
-|3|M|6g|-|M160 X 3-6g|0.0480|159.952|160|159.577|-|158.003|157.779|156.704|155.931|0.224
-|3|M|6H|-|M160 X 3-6H|-|160.733|160|160|-|158.351|158.051|157.252|156.752|0.3
-|3|M|4g6g|-|M170 X 3-4g6g|0.0480|169.952|170|169.577|-|168.003|167.863|166.704|166.015|0.14
-|3|M|6g|-|M170 X 3-6g|0.0480|169.952|170|169.577|-|168.003|167.779|166.704|165.931|0.224
-|3|M|6H|-|M170 X 3-6H|-|170.733|170|170|-|168.351|168.051|167.252|166.752|0.3
-|3|M|4g6g|-|M180 X 3-4g6g|0.0480|179.952|180|179.577|-|178.003|177.863|176.704|176.015|0.14
-|3|M|6g|-|M180 X 3-6g|0.0480|179.952|180|179.577|-|178.003|177.779|176.704|175.931|0.224
-|3|M|6H|-|M180 X 3-6H|-|180.733|180|180|-|178.351|178.051|177.252|176.752|0.3
-|3|M|4g6g|-|M190 X 3-4g6g|0.0480|189.952|190|189.577|-|188.003|187.843|186.704|185.995|0.16
-|3|M|6g|-|M190 X 3-6g|0.0480|189.952|190|189.577|-|188.003|187.753|186.704|185.905|0.25
-|3|M|6H|-|M190 X 3-6H|-|190.768|190|190|-|188.386|188.051|187.252|186.752|0.335
-|3|M|4g6g|-|M200 X 3-4g6g|0.0480|199.952|200|199.577|-|198.003|197.843|196.704|195.995|0.16
-|3|M|6g|-|M200 X 3-6g|0.0480|199.952|200|199.577|-|198.003|197.753|196.704|195.905|0.25
-|3|M|6H|-|M200 X 3-6H|-|200.768|200|200|-|198.386|198.051|197.252|196.752|0.335";
    }
}

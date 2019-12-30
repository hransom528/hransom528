#Harris Ransom
#PizzaPi Order Script

#Imports pizzapi lib
#sudo pip3 install pizzapi
from pizzapi import * 

#Creates customer and address objects
customer = Customer('Harris', 'Ransom', 'hransom528@gmail.com', '6093132105')
address = Address('4212 Church Road', 'Mount Laurel', 'NJ', '08054')

#Creates store object
store = address.closest_store()

#Creates menu object
menu = store.get_menu()

#Searches menu
menu.search(Name='Coke')
menu.search(Name='Pepperoni')

#Creates order object
order = Order(store, customer, address)

#Adds items to order
order.add_item('20BCOKE') #20oz Coke Bottle
order.add_item('12SCPFEAST') #Medium Hand Tossed Ultimate Pepperoni

#Remove items (optional)
#order.remove_item('20BCOKE')

#Creates credit card object
#card = PaymentObject(card_num, last_4,ccv,expiration)
card = PaymentObject('4100123422343234', '0115', '777', '90210') #Fake credit card (duh!)

#Places order
#order.place(card)   #place is for real!
order.pay_with(card) #pay_with is for testing

#Confirms order
print("All done! Your order is successfully placed.")
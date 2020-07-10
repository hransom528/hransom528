import tensorflow
import keras
import sklearn
from sklearn import linear_model
import numpy as np
import pandas
import matplotlib.pyplot as pyplot
import pickle

data = pandas.read_csv("student-mat.csv", sep=";")
data = data[["G1", "G2", "G3", "studytime", "failures", "absences"]]
print(data.head())

#Sets up datasets
predict = "G3"
x = np.array(data.drop([predict], 1))
y = np.array(data[predict])

#Splits x and y dataset into test and train sets
x_train, x_test, y_train, y_test = sklearn.model_selection.train_test_split(x, y, test_size=0.1)

#Creates linear regression and best fit line
linear = linear_model.LinearRegression()
linear.fit(x_train, y_train)

#Gets accuracy of model
acc = linear.score(x_test, y_test)
print(acc)


#Outputs info of model
print("Coefficient: ", linear.coef_)
print("Intercept: ", linear.intercept_)

#Predicts data
prediction = linear.predict(x_test)
for x in range(len(prediction)):
    print(prediction[x], x_test[x], y_test[x])

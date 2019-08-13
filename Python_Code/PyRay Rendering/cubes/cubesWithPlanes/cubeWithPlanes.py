#Rendering example of PyRay
#NOTE: The PyRay library is needed. Install with pip install raypy

from pyray.shapes.cube import *

#Creates still of cube with cutting planes
cube_with_cuttingplanes(7, popup=True)

#Creates a series of cubes with cutting planes. 
#NOTE: These images can be converted to a video with the ffmpeg program. 
for i in range(3, 15):
    cube_with_cuttingplanes(numTerms = i,im_ind = i-3)

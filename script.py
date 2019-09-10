from turtle import *
from freegames import vector,square

p1xy=vector(-100,0)
p1aim=vector(4,0)
p1body=set()

p2xy=vector(100,0)
p2aim=vector(-4,0)
p2body=set()


def inside(head):
    return -200<head.x<200 and -200<head.y<200


def draw():
    p1xy.move(p1aim)
    p1head=p1xy.copy()

    p2xy.move(p2aim)
    p2head=p2xy.copy()


    p1body.add(p1head)
    p2body.add(p2head)

    if not inside(p1head) or p1head in p2body:
        print('blue wins!')
        return

    if not inside(p2head) or p2head in p1body:
        print('red wins!')
        return



    square(p1xy.x,p1xy.y,3,'red')
    square(p2xy.x,p2xy.y,3,'blue')

    update()
    ontimer(draw, 50)



setup(420,420,370,0)
hideturtle()
tracer(False)
listen()
onkey(lambda :p1aim.rotate(90),'a')
onkey(lambda :p1aim.rotate(-90),'d')
onkey(lambda :p2aim.rotate(90),'k')
onkey(lambda :p2aim.rotate(-90),'l')

draw()
done()
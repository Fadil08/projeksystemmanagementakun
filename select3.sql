select  country,count(last_name)
from employees
group by country



select 
from employees e join orders o on e.employee_id = o.employees_id


select *
from products p
join order_details od on .product_id od.product_id
join orders o on o.order_id = od.product_id
where p.discount
gru
export function sortDataBySales(data){
    return data = (data.sort(
        (p1, p2) => 
        (p1.value < p2.value) ? 1 : (p1.value > p2.value) ? -1 : 0));
}

function dynamicArray(n, queries) {
   let lastanswer = 0;
   let b = new Array();
   let i = 0;
   let c = queries.length;
   // console.log(queries[0].length);
   let a = new Array();
   for (i = 1; i <= n; i++) {
      b.push(new Array());
   }
   // console.log(c);

   for (i = 0; i < c; i++) { 
      // console.log("this is the  element- ",queries[i][0]);
      //console.log(queries[i][0]);
      if (queries[i][0] == 1) { 
			// console.log("this is the first element- ",queries[i][1]); 
         let idx = ((queries[i][1] ^ lastanswer) % n);
         //  console.log("this is the idx in 1 ",idx);
         b[idx].push(queries[i][2]);
         //     console.log("this is the array in 1 ",b);
      }
      if (queries[i][0] == 2) { 
         // console.log("this is the second element- ",queries[i][2]); 
         let idx = ((queries[i][1] ^ lastanswer) % n);
         lastanswer = b[idx][(queries[i][2]) % ((b[idx]).length)];
         a.push(lastanswer);
         // console.log("this is the answer",lastanswer);
         //  console.log("this is solace" , a )
      }
   }

   return a;
   /*
  console.log(queries[0]);
   console.log(queries[0][0]);
 */
}